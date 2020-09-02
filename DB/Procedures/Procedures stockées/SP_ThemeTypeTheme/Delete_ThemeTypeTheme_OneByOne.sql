CREATE PROCEDURE [dbo].[Delete_ThemeTypeTheme_OneByOne]
	@themeID int,
	@typeThemeID int

AS

	BEGIN 
		DELETE FROM ThemeTypeTheme WHERE TypeThemeID = @typeThemeID AND ThemeID = @themeID
	END
