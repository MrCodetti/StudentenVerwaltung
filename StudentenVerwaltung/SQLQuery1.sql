ALTER PROCEDURE [dbo].[uspStudenten]
(
@MatrikelNr INT = NULL,
@Vorname VARCHAR(20) = NULL,
@Nachname VARCHAR(20) = NULL,
@Geschlecht VARCHAR(20) = NULL,
@Geburtsdatum VARCHAR(10) = NULL,
@Mail VARCHAR(20) = NULL,
@ZweigID INT = NULL,
@MentorID INT = NULL,
@Studienzweig VARCHAR(25) = NULL,
@Mentor VARCHAR(25) = NULL,
@ActionType VARCHAR(25)
)
AS
BEGIN
IF @ActionType = 'SaveData'
BEGIN
IF NOT EXISTS (SELECT * FROM tblStudenten WHERE MatrikelNr=@MatrikelNr)
BEGIN
INSERT INTO tblStudenten(Vorname, Nachname, Geschlecht, Geburtsdatum, Mail, ZweigID, MentorID)
VALUES (@Vorname,@Nachname,@Geschlecht,@Geburtsdatum, @Mail, 
(SELECT ZweigID FROM tblZweig WHERE Studienzweig='@Studienzweig'),
(SELECT MentorID FROM tblMentor WHERE Mentor='@Mentor'))
END
ELSE
BEGIN
UPDATE tblStudenten SET Vorname=@Vorname, Nachname=@Nachname, Geschlecht=@Geschlecht, Geburtsdatum=@Geburtsdatum, Mail=@Mail,
ZweigID=(SELECT ZweigID FROM tblZweig WHERE Studienzweig='@Studienzweig'),
MentorID=(SELECT MentorID FROM tblMentor WHERE Mentor='@Mentor')
WHERE MatrikelNr=@MatrikelNr
END
END
IF @ActionType = 'DeleteData'
BEGIN
DELETE tblStudenten WHERE MatrikelNr=@MatrikelNr
END
IF @ActionType = 'FetchData'
BEGIN
SELECT dbo.tblStudenten.MatrikelNr, dbo.tblStudenten.Vorname, dbo.tblStudenten.Nachname, dbo.tblStudenten.Geschlecht, dbo.tblStudenten.Geburtsdatum, dbo.tblStudenten.Mail, dbo.tblMentor.Mentor, dbo.tblZweig.Studienzweig
FROM            dbo.tblMentor INNER JOIN
                         dbo.tblStudenten ON dbo.tblMentor.MentorID = dbo.tblStudenten.MentorID INNER JOIN
                         dbo.tblZweig ON dbo.tblStudenten.ZweigID = dbo.tblZweig.ZweigID
END
IF @ActionType = 'FetchRecord'
BEGIN
SELECT  dbo.tblStudenten.MatrikelNr, dbo.tblStudenten.Vorname, dbo.tblStudenten.Nachname, dbo.tblStudenten.Geschlecht, dbo.tblStudenten.Geburtsdatum, dbo.tblStudenten.Mail, dbo.tblMentor.Mentor, dbo.tblZweig.Studienzweig
FROM            dbo.tblMentor INNER JOIN
                         dbo.tblStudenten ON dbo.tblMentor.MentorID = dbo.tblStudenten.MentorID INNER JOIN
                         dbo.tblZweig ON dbo.tblStudenten.ZweigID = dbo.tblZweig.ZweigID
WHERE MatrikelNr=@MatrikelNr
END
END