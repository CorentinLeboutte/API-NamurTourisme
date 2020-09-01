CREATE PROCEDURE [dbo].[Create_Adresse]

	@longitude nvarchar(50),
	@latitude nvarchar(50),
	@rue nvarchar(50),
	@numero int,
	@boite datetime2(7),
	@ville nvarchar(50),
	@codePostal nvarchar(50),
	@region nvarchar(50),
	@pays nvarchar(320)

AS
	BEGIN
		INSERT INTO Adresse (Longitude, Latitude, Rue, Numero, Boite, Ville, CodePostal, Region, Pays)
			VALUES
				(@longitude, @latitude, @rue, @numero, @boite, @ville, @codePostal, @region, @pays)
	END
