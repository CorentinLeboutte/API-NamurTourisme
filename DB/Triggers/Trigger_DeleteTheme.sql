CREATE TRIGGER [dbo].[Trigger_DeleteTheme]
ON Theme
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @themeID int;
	SET @themeID = (SELECT themeID FROM deleted)
	UPDATE Theme
		 SET 
			isActive=0
		WHERE ThemeID = @themeID;
END