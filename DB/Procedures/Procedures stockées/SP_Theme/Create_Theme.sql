CREATE PROCEDURE [dbo].[Create_Theme]
	@nom nvarchar(50),
	@description nvarchar(320),
	@heureOuverture datetime2(7),
	@heureFermeture datetime2(7),
	@lienSiteWeb nvarchar(320),
	@adresseId int

AS
	BEGIN
		INSERT INTO Theme (Nom,[Description], HeureOuverture, HeureFermeture, LienSiteWeb, AdresseID)
			VALUES
				(@nom, @description, @heureOuverture, @heureFermeture, @lienSiteWeb, @adresseId)
	END
