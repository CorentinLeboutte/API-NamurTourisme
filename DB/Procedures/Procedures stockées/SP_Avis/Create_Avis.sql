CREATE PROCEDURE [dbo].[Create_Avis]
	@utilisateurId int,
	@themeId int,
	@note int,
	@commentaire nvarchar(320),
	@dateCommentaire datetime,
	@isActive bit

AS
	BEGIN
		INSERT INTO Avis(UtilisateurID,ThemeID, Note, Commentaire, DateCommentaire, isActive)
			VALUES
				(@utilisateurId, @themeId, @note, @commentaire, @dateCommentaire, @isActive)
	END