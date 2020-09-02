CREATE TRIGGER [dbo].[Trigger_DeleteUtilisateur]
ON Utilisateur
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @utilisateurID int;
	SET @utilisateurID = (SELECT UtilisateurID FROM deleted)
	UPDATE Utilisateur
		 SET 
			isActive=0
		WHERE UtilisateurID = @utilisateurID;
END
