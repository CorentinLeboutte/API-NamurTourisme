CREATE PROCEDURE [dbo].[Create_Theme]
	@nom nvarchar(50),
	@description nvarchar(320),
	@heureOuverture datetime2(7),
	@heureFermeture datetime2(7),
	@lienSiteWeb nvarchar(320),
	@adresseId int,
	@typeDePaiement nvarchar(50),
	@prixMin money,
	@prixMax money

AS
	BEGIN
		INSERT INTO Theme (Nom,[Description], HeureOuverture, HeureFermeture, LienSiteWeb, AdresseID, TypeDePaiement,PrixMin, PrixMax)
			VALUES
				(@nom, @description, @heureOuverture, @heureFermeture, @lienSiteWeb, @adresseId, @typeDePaiement, @prixMin, @prixMax)
	END
