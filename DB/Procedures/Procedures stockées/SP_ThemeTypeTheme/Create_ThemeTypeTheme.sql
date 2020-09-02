CREATE PROCEDURE [dbo].[Create_ThemeTypeTheme]
	@themeID int,
	@typeThemeID int
AS
	BEGIN
		INSERT INTO ThemeTypeTheme (themeID, TypeThemeID)
			
			VALUES
				(@themeID, @typeThemeID)
	END