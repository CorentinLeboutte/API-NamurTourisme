CREATE PROCEDURE [dbo].[Update_Theme]
	@themeID int,
	@nom nvarchar(50),
	@description nvarchar(320),
	@heureOuverture datetime2(7),
	@heureFermeture datetime2(7),
	@lienSiteWeb nvarchar(320),
	@adresseID int,
	@typeDePaiement nvarchar(50),
	@prixMin money,
	@prixMax money,
	@image nvarchar(50)


AS
	
	BEGIN
		UPDATE Theme SET 
		Nom = @nom,
		[Description] = @description,
		AdresseId = @adresseID,
		HeureOuverture = @heureOuverture,
		HeureFermeture = @heureFermeture,
		LienSiteWeb = @lienSiteWeb,
		TypeDePaiement = @typeDePaiement,
		PrixMin = @prixMin,
		PrixMax = @prixMax,
		[Image] = @image
		

		WHERE ThemeID = @themeID

	END