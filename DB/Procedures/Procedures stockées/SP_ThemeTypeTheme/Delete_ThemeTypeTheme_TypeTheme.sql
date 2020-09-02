CREATE PROCEDURE [dbo].[Delete_ThemeTypeTheme_TypeTheme]
	@typeThemeID int
AS

	BEGIN
		DELETE FROM ThemeTypeTheme WHERE TypeThemeID = @typeThemeID
	END
