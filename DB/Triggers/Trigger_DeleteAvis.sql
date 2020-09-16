CREATE TRIGGER [dbo].[Trigger_DeleteAvis]
ON Avis
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @avisID int;
	SET @avisID = (SELECT AvisID FROM deleted)
	UPDATE Avis
		 SET 
			isActive=0
		WHERE AvisID = @avisID;
END