CREATE PROCEDURE [dbo].[Delete_Organisateur]
	@OrganisateurID int
AS
	
	BEGIN
		DELETE FROM Organisateur WHERE OrganisateurID = @OrganisateurID
	END
