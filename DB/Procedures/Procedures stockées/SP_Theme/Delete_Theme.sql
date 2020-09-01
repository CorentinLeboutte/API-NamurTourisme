CREATE PROCEDURE [dbo].[Delete_Theme]
	@themeID int
AS
	
	BEGIN
		DELETE FROM Theme WHERE ThemeID = @themeID
	END
