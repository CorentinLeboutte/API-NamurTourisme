CREATE TRIGGER [dbo].[Trigger_DeletePlanning]
ON Planning
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @planningID int;
	SET @planningID = (SELECT PlanningID FROM deleted)
	UPDATE Planning
		 SET 
			isActive=0
		WHERE PlanningID = @planningID;
END
