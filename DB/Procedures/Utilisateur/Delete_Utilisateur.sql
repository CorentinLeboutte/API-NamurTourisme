CREATE PROCEDURE [dbo].[Delete_Utilisateur]
	@UtilisateurID int
AS
	
	BEGIN
		DELETE FROM Utilisateur WHERE UtilisateurID = @UtilisateurID
	END
