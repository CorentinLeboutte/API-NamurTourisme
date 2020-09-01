CREATE PROCEDURE [dbo].[Create_Theme]
	@nom nvarchar(50),
	@description nvarchar(320),
	@heureOuverture nvarchar(50),
	@heureFermeture int,
	@lienSiteWeb datetime2(7),
	@adresseId nvarchar(50)

AS
	BEGIN
		INSERT INTO Theme (Nom,[Description], HeureOuverture, HeureFermeture, LienSiteWeb, AdresseID)
			VALUES
				(@nom, @description, @heureOuverture, @heureFermeture, @lienSiteWeb, @adresseId)
	END
