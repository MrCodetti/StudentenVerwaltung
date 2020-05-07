using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentenVerwaltung
{
    public partial class FrmStudenten : Form
    {
        string connString = (@"Data Source = DESKTOP-0S31MOV\SQLKURS;" +
                             "Initial Catalog=dbStudentenVerwaltung;Integrated Security=sspi");

        SqlConnection sqlconn;
        SqlCommand sqlcmd;
        string MatrikelNr = "";

        public FrmStudenten()
        {
            InitializeComponent();
            sqlconn = new SqlConnection(connString);
            sqlconn.Open();
        }

        private void FrmStudenten_Load(object sender, EventArgs e)
        {
            dgvStudenten.AutoGenerateColumns = false;
            dgvStudenten.DataSource = FetchStDetails();
            cmbStZweig();
            cmbStMentor();
        }

        private DataTable FetchStDetails()
        {
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            DataTable dt = new DataTable();
            sqlcmd = new SqlCommand("uspStudenten", sqlconn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@ActionType", "FetchData");
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            da.Fill(dt);
            return dt;
        }

        private DataTable FetchStRecords(string maNr)
        {
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            DataTable sqlDt = new DataTable();
            sqlcmd = new SqlCommand("uspStudenten", sqlconn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@ActionType", "FetchRecord");
            sqlcmd.Parameters.AddWithValue("@MatrikelNr", maNr);
            SqlDataAdapter sqlDa = new SqlDataAdapter(sqlcmd);
            sqlDa.Fill(sqlDt);
            return sqlDt;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txbVorname.Text == "" &&
                txbNachname.Text == "" &&
                cmbGeschlecht.SelectedIndex <= -1 &&
                cmbMentor.SelectedIndex <= -1 &&
                cmbStudienzweig.SelectedIndex <= -1)
            {
                MessageBox.Show("Bitte Keine freie felder!", "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (sqlconn.State == ConnectionState.Closed)
                    {
                        sqlconn.Open();
                    }
                    sqlcmd = new SqlCommand("uspStudenten", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@ActionType", "SaveData");
                    sqlcmd.Parameters.AddWithValue("@MatrikelNr", MatrikelNr);
                    sqlcmd.Parameters.AddWithValue("@Vorname", txbVorname.Text);
                    sqlcmd.Parameters.AddWithValue("@Nachname", txbNachname.Text);
                    sqlcmd.Parameters.AddWithValue("@Geschlecht", cmbGeschlecht.Text);
                    sqlcmd.Parameters.AddWithValue("@Geburtsdatum", txbGeburt.Text);
                    sqlcmd.Parameters.AddWithValue("@Mail", txbMail.Text);
                    sqlcmd.Parameters.AddWithValue("@Studienzweig", cmbStudienzweig.Text);
                    sqlcmd.Parameters.AddWithValue("@Mentor", cmbMentor.Text);
                    int numRes = sqlcmd.ExecuteNonQuery();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Record Saved Successfully !!!");
                        ClearAllData();
                    }
                    else
                    {
                        MessageBox.Show("Try Again !!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ClearAllData()
        {
            btnSave.Text = "Save";
            txbVorname.Clear();
            txbNachname.Clear();
            txbMail.Clear();
            txbGeburt.Clear();
            cmbGeschlecht.SelectedIndex = -1;
            cmbStudienzweig.SelectedIndex = -1;
            cmbMentor.SelectedIndex = -1;
            MatrikelNr = "";
            dgvStudenten.AutoGenerateColumns = false;
            dgvStudenten.DataSource = FetchStDetails();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MatrikelNr != "")
            {
                try
                {
                    if (sqlconn.State == ConnectionState.Closed)
                    {
                        sqlconn.Open();
                    }
                    DataTable sqlDt = new DataTable();
                    sqlcmd = new SqlCommand("uspStudenten", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@ActionType", "DeleteData");
                    sqlcmd.Parameters.AddWithValue("@MatrikelNr", MatrikelNr);
                    int numRes = sqlcmd.ExecuteNonQuery();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Record Deleted Successfully !!!");
                        ClearAllData();
                    }
                    else
                    {
                        MessageBox.Show("Try Again !!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a record !!!");
            }
        }

        private void dgvStudenten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnSave.Text = "Update";
                MatrikelNr = dgvStudenten.Rows[e.RowIndex].Cells[0].Value.ToString();
                DataTable DT = FetchStRecords(MatrikelNr);
                if (DT.Rows.Count > 0)
                {
                    txbVorname.Text = DT.Rows[0][1].ToString();
                    txbNachname.Text = DT.Rows[0][2].ToString();
                    cmbGeschlecht.Text = DT.Rows[0][3].ToString();
                    txbMail.Text = DT.Rows[0][5].ToString();
                    txbGeburt.Text = DT.Rows[0][4].ToString();
                    cmbStudienzweig.Text = DT.Rows[0][7].ToString();
                    cmbMentor.Text = DT.Rows[0][6].ToString();
                }
                else
                {
                    ClearAllData();
                }
            }
        }

        private void cmbStZweig()
        {
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            sqlcmd = new SqlCommand("uspZweig", sqlconn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader drZweig = sqlcmd.ExecuteReader();
            while (drZweig.Read())
            {
                cmbStudienzweig.Items.Add(drZweig[0]);
            }
            drZweig.Close();
        }
        private void cmbStMentor()
        {
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            sqlcmd = new SqlCommand("uspMentor", sqlconn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader drMentor = sqlcmd.ExecuteReader();
            while (drMentor.Read())
            {
                cmbMentor.Items.Add(drMentor[0]);
            }
            drMentor.Close();
        }
    }
}
