CREATE PROCEDURE [dbo].[Delete_TypeTheme]
	@typeThemeID int
AS
	
	BEGIN
		DELETE FROM TypeTheme WHERE TypeThemeID = @typeThemeID
	END