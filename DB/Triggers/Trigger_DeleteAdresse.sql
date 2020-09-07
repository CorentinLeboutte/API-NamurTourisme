CREATE TRIGGER [dbo].[Trigger_DeleteAdresse]
ON Adresse
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @adresseID int;
	SET @adresseID = (SELECT AdresseID FROM deleted)
	UPDATE Adresse
		 SET 
			isActive=0
		WHERE AdresseID = @adresseID;
END