CREATE PROCEDURE [dbo].[Delete_Adresse]
	@adresseID int
AS
	
	BEGIN
		DELETE FROM Adresse WHERE AdresseID = @adresseID
	END