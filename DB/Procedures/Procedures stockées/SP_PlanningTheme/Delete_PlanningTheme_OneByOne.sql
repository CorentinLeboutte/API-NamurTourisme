CREATE PROCEDURE [dbo].[Delete_PlanningTheme_OneByOne]
	@planningID int,
	@themeID int

AS

	BEGIN 
		DELETE FROM PlanningTheme WHERE ThemeID = @themeID AND PlanningID = @planningID
	END
