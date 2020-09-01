CREATE PROCEDURE [dbo].[Delete_Planning]
	@planningID int
AS
	
	BEGIN
		DELETE FROM Planning WHERE PlanningID = @planningID
	END