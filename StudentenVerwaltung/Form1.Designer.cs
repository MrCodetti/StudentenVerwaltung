namespace StudentenVerwaltung
{
    partial class FrmStudenten
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbStudenten = new System.Windows.Forms.GroupBox();
            this.txbGeburt = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbMentor = new System.Windows.Forms.ComboBox();
            this.cmbStudienzweig = new System.Windows.Forms.ComboBox();
            this.cmbGeschlecht = new System.Windows.Forms.ComboBox();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.txbNachname = new System.Windows.Forms.TextBox();
            this.txbVorname = new System.Windows.Forms.TextBox();
            this.lblMentor = new System.Windows.Forms.Label();
            this.lblStudienzweig = new System.Windows.Forms.Label();
            this.lblGeburtsdatum = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblGeschlecht = new System.Windows.Forms.Label();
            this.lblNachname = new System.Windows.Forms.Label();
            this.lblVorname = new System.Windows.Forms.Label();
            this.dgvStudenten = new System.Windows.Forms.DataGridView();
            this.colMartikelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGeschlecht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGeburt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStZweig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMentor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbStudenten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenten)).BeginInit();
            this.SuspendLayout();
            // 
            // grbStudenten
            // 
            this.grbStudenten.Controls.Add(this.txbGeburt);
            this.grbStudenten.Controls.Add(this.btnDelete);
            this.grbStudenten.Controls.Add(this.btnClear);
            this.grbStudenten.Controls.Add(this.btnSave);
            this.grbStudenten.Controls.Add(this.cmbMentor);
            this.grbStudenten.Controls.Add(this.cmbStudienzweig);
            this.grbStudenten.Controls.Add(this.cmbGeschlecht);
            this.grbStudenten.Controls.Add(this.txbMail);
            this.grbStudenten.Controls.Add(this.txbNachname);
            this.grbStudenten.Controls.Add(this.txbVorname);
            this.grbStudenten.Controls.Add(this.lblMentor);
            this.grbStudenten.Controls.Add(this.lblStudienzweig);
            this.grbStudenten.Controls.Add(this.lblGeburtsdatum);
            this.grbStudenten.Controls.Add(this.lblMail);
            this.grbStudenten.Controls.Add(this.lblGeschlecht);
            this.grbStudenten.Controls.Add(this.lblNachname);
            this.grbStudenten.Controls.Add(this.lblVorname);
            this.grbStudenten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbStudenten.Location = new System.Drawing.Point(13, 13);
            this.grbStudenten.Name = "grbStudenten";
            this.grbStudenten.Size = new System.Drawing.Size(775, 293);
            this.grbStudenten.TabIndex = 0;
            this.grbStudenten.TabStop = false;
            this.grbStudenten.Text = "Studenten:";
            // 
            // txbGeburt
            // 
            this.txbGeburt.Location = new System.Drawing.Point(116, 171);
            this.txbGeburt.Name = "txbGeburt";
            this.txbGeburt.Size = new System.Drawing.Size(208, 22);
            this.txbGeburt.TabIndex = 26;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(541, 197);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 33);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(541, 128);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 33);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(541, 57);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 33);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbMentor
            // 
            this.cmbMentor.FormattingEnabled = true;
            this.cmbMentor.Location = new System.Drawing.Point(116, 241);
            this.cmbMentor.Name = "cmbMentor";
            this.cmbMentor.Size = new System.Drawing.Size(208, 24);
            this.cmbMentor.TabIndex = 22;
            // 
            // cmbStudienzweig
            // 
            this.cmbStudienzweig.FormattingEnabled = true;
            this.cmbStudienzweig.Location = new System.Drawing.Point(116, 207);
            this.cmbStudienzweig.Name = "cmbStudienzweig";
            this.cmbStudienzweig.Size = new System.Drawing.Size(208, 24);
            this.cmbStudienzweig.TabIndex = 21;
            // 
            // cmbGeschlecht
            // 
            this.cmbGeschlecht.FormattingEnabled = true;
            this.cmbGeschlecht.Items.AddRange(new object[] {
            "Weiblich",
            "Männlich"});
            this.cmbGeschlecht.Location = new System.Drawing.Point(116, 102);
            this.cmbGeschlecht.Name = "cmbGeschlecht";
            this.cmbGeschlecht.Size = new System.Drawing.Size(208, 24);
            this.cmbGeschlecht.TabIndex = 19;
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(116, 137);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(208, 22);
            this.txbMail.TabIndex = 17;
            // 
            // txbNachname
            // 
            this.txbNachname.Location = new System.Drawing.Point(116, 68);
            this.txbNachname.Name = "txbNachname";
            this.txbNachname.Size = new System.Drawing.Size(208, 22);
            this.txbNachname.TabIndex = 15;
            // 
            // txbVorname
            // 
            this.txbVorname.Location = new System.Drawing.Point(116, 31);
            this.txbVorname.Name = "txbVorname";
            this.txbVorname.Size = new System.Drawing.Size(208, 22);
            this.txbVorname.TabIndex = 14;
            // 
            // lblMentor
            // 
            this.lblMentor.AutoSize = true;
            this.lblMentor.Location = new System.Drawing.Point(50, 244);
            this.lblMentor.Name = "lblMentor";
            this.lblMentor.Size = new System.Drawing.Size(49, 16);
            this.lblMentor.TabIndex = 13;
            this.lblMentor.Text = "Mentor";
            // 
            // lblStudienzweig
            // 
            this.lblStudienzweig.AutoSize = true;
            this.lblStudienzweig.Location = new System.Drawing.Point(12, 210);
            this.lblStudienzweig.Name = "lblStudienzweig";
            this.lblStudienzweig.Size = new System.Drawing.Size(87, 16);
            this.lblStudienzweig.TabIndex = 12;
            this.lblStudienzweig.Text = "Studienzweig";
            // 
            // lblGeburtsdatum
            // 
            this.lblGeburtsdatum.AutoSize = true;
            this.lblGeburtsdatum.Location = new System.Drawing.Point(7, 174);
            this.lblGeburtsdatum.Name = "lblGeburtsdatum";
            this.lblGeburtsdatum.Size = new System.Drawing.Size(92, 16);
            this.lblGeburtsdatum.TabIndex = 11;
            this.lblGeburtsdatum.Text = "Geburtsdatum";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(66, 140);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(33, 16);
            this.lblMail.TabIndex = 10;
            this.lblMail.Text = "Mail";
            // 
            // lblGeschlecht
            // 
            this.lblGeschlecht.AutoSize = true;
            this.lblGeschlecht.Location = new System.Drawing.Point(24, 105);
            this.lblGeschlecht.Name = "lblGeschlecht";
            this.lblGeschlecht.Size = new System.Drawing.Size(75, 16);
            this.lblGeschlecht.TabIndex = 9;
            this.lblGeschlecht.Text = "Geschlecht";
            // 
            // lblNachname
            // 
            this.lblNachname.AutoSize = true;
            this.lblNachname.Location = new System.Drawing.Point(25, 71);
            this.lblNachname.Name = "lblNachname";
            this.lblNachname.Size = new System.Drawing.Size(74, 16);
            this.lblNachname.TabIndex = 8;
            this.lblNachname.Text = "Nachname";
            // 
            // lblVorname
            // 
            this.lblVorname.AutoSize = true;
            this.lblVorname.Location = new System.Drawing.Point(36, 34);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(63, 16);
            this.lblVorname.TabIndex = 7;
            this.lblVorname.Text = "Vorname";
            // 
            // dgvStudenten
            // 
            this.dgvStudenten.AllowUserToAddRows = false;
            this.dgvStudenten.AllowUserToDeleteRows = false;
            this.dgvStudenten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMartikelID,
            this.colVorname,
            this.colNachname,
            this.colGeschlecht,
            this.colMail,
            this.colGeburt,
            this.colStZweig,
            this.colMentor});
            this.dgvStudenten.Location = new System.Drawing.Point(13, 313);
            this.dgvStudenten.Name = "dgvStudenten";
            this.dgvStudenten.ReadOnly = true;
            this.dgvStudenten.RowHeadersVisible = false;
            this.dgvStudenten.Size = new System.Drawing.Size(775, 285);
            this.dgvStudenten.TabIndex = 1;
            this.dgvStudenten.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudenten_CellDoubleClick);
            // 
            // colMartikelID
            // 
            this.colMartikelID.DataPropertyName = "MatrikelNr";
            this.colMartikelID.HeaderText = "MatrikelNr";
            this.colMartikelID.Name = "colMartikelID";
            this.colMartikelID.ReadOnly = true;
            // 
            // colVorname
            // 
            this.colVorname.DataPropertyName = "Vorname";
            this.colVorname.HeaderText = "Vorname";
            this.colVorname.Name = "colVorname";
            this.colVorname.ReadOnly = true;
            // 
            // colNachname
            // 
            this.colNachname.DataPropertyName = "Nachname";
            this.colNachname.HeaderText = "Nachname";
            this.colNachname.Name = "colNachname";
            this.colNachname.ReadOnly = true;
            // 
            // colGeschlecht
            // 
            this.colGeschlecht.DataPropertyName = "Geschlecht";
            this.colGeschlecht.HeaderText = "Geschlecht";
            this.colGeschlecht.Name = "colGeschlecht";
            this.colGeschlecht.ReadOnly = true;
            // 
            // colMail
            // 
            this.colMail.DataPropertyName = "Mail";
            this.colMail.HeaderText = "Mail";
            this.colMail.Name = "colMail";
            this.colMail.ReadOnly = true;
            // 
            // colGeburt
            // 
            this.colGeburt.DataPropertyName = "Geburtsdatum";
            this.colGeburt.HeaderText = "Geburtsdatum";
            this.colGeburt.Name = "colGeburt";
            this.colGeburt.ReadOnly = true;
            // 
            // colStZweig
            // 
            this.colStZweig.DataPropertyName = "Studienzweig";
            this.colStZweig.HeaderText = "Studienzweig";
            this.colStZweig.Name = "colStZweig";
            this.colStZweig.ReadOnly = true;
            // 
            // colMentor
            // 
            this.colMentor.DataPropertyName = "Mentor";
            this.colMentor.HeaderText = "Mentor";
            this.colMentor.Name = "colMentor";
            this.colMentor.ReadOnly = true;
            // 
            // FrmStudenten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.dgvStudenten);
            this.Controls.Add(this.grbStudenten);
            this.Name = "FrmStudenten";
            this.ShowIcon = false;
            this.Text = "Studenten Verwaltung";
            this.Load += new System.EventHandler(this.FrmStudenten_Load);
            this.grbStudenten.ResumeLayout(false);
            this.grbStudenten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenten)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.GroupBox grbStudenten;
        private System.Windows.Forms.ComboBox cmbGeschlecht;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.TextBox txbNachname;
        private System.Windows.Forms.TextBox txbVorname;
        private System.Windows.Forms.Label lblMentor;
        private System.Windows.Forms.Label lblStudienzweig;
        private System.Windows.Forms.Label lblGeburtsdatum;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblGeschlecht;
        private System.Windows.Forms.Label lblNachname;
        private System.Windows.Forms.Label lblVorname;
        private System.Windows.Forms.DataGridView dgvStudenten;
        private System.Windows.Forms.ComboBox cmbMentor;
        private System.Windows.Forms.ComboBox cmbStudienzweig;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbGeburt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMartikelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNachname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGeschlecht;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGeburt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStZweig;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMentor;
    }
}

