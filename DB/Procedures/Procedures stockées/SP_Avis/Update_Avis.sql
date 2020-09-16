CREATE PROCEDURE [dbo].[Update_Avis]
	@avisID int,
	@utilisateurID int,
	@themeID int,
	@note int,
	@commentaire nvarchar(320),
	@dateCommentaire datetime,
	@isActive bit


AS
	
	BEGIN
		UPDATE Avis SET 
		Note = @note,
		Commentaire = @commentaire,
		DateCommentaire = @dateCommentaire,
		isActive = @isActive

		WHERE AvisID = @avisID

	END