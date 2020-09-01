CREATE PROCEDURE [dbo].[Update_Adresse]

	@adresseID int,
	@longitude nvarchar(50),
	@latitude nvarchar(50),
	@rue nvarchar(320),
	@numero nvarchar(10),
	@boite nvarchar(5),
	@ville nvarchar(50),
	@codePostal int,
	@region nvarchar(50),
	@pays nvarchar(50)


AS
	
	BEGIN
		UPDATE Adresse SET 
		Longitude = @longitude,
		Latitude = @latitude,
		Rue = @rue,
		Numero = @numero,
		Boite = @boite,
		Ville = @ville,
		CodePostal = @codePostal,
		Region = @region,
		Pays = @pays


		WHERE AdresseID = @adresseID

	END
