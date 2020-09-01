CREATE PROCEDURE [dbo].[Delete_PlanningTheme_Planning]
	@planningID int
AS
	BEGIN
		DELETE FROM PlanningTheme WHERE PlanningID = @planningID
	END
