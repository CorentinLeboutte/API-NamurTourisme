CREATE PROCEDURE [dbo].[Delete_PlanningTheme_Theme]
	@themeID int
AS

	BEGIN
		DELETE FROM PlanningTheme WHERE ThemeID = @themeID
	END
