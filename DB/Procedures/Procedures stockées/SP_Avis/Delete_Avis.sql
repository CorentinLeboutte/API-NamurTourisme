CREATE PROCEDURE [dbo].[Delete_Avis]
	@avisID int
AS
	BEGIN
		DELETE FROM Avis WHERE AvisID = @avisID
	END
