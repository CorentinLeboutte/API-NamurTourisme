CREATE PROCEDURE [dbo].[Delete_ThemeTypeTheme_Theme]
	@themeID int
AS
	BEGIN
		DELETE FROM ThemeTypeTheme WHERE ThemeID = @themeID
	END