CREATE PROCEDURE [dbo].[Update_Theme]
	@themeID int,
	@nom nvarchar(50),
	@description nvarchar(320),
	@heureOuverture datetime2(7),
	@heureFermeture datetime2(7),
	@lienSiteWeb nvarchar(320),
	@adresseID int


AS
	
	BEGIN
		UPDATE Theme SET 
		Nom = @nom,
		[Description] = @description,
		AdresseId = @adresseID,
		HeureOuverture = @heureOuverture,
		HeureFermeture = @heureFermeture,
		LienSiteWeb = @lienSiteWeb
		


		WHERE ThemeID = @themeID

	END