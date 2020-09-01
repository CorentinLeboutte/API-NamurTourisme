CREATE PROCEDURE [dbo].[Delete_Utilisateur]
	@utilisateurID int
AS
	
	BEGIN
		DELETE FROM Utilisateur WHERE UtilisateurID = @utilisateurID
	END
