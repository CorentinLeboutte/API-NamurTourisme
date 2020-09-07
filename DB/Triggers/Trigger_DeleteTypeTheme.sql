CREATE TRIGGER [dbo].[Trigger_DeleteTypeTheme]
ON TypeTheme
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @typeThemeID int;
	SET @typeThemeID = (SELECT TypeThemeID FROM deleted)
	UPDATE TypeTheme
		 SET 
			isActive=0
		WHERE TypeThemeID = @typeThemeID;
END