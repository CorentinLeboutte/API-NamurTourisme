CREATE PROCEDURE [dbo].[Create_Theme]
	@nom nvarchar(50),
	@description nvarchar(320),
	@heureOuverture datetime2(7),
	@heureFermeture datetime2(7),
	@lienSiteWeb nvarchar(320),
	@adresseId int,
	@typeDePaiement nvarchar(50),
	@prixMin money,
	@prixMax money,
	@image nvarchar(50)

AS
	BEGIN
		INSERT INTO Theme (Nom,[Description], HeureOuverture, HeureFermeture, LienSiteWeb, AdresseID, TypeDePaiement,PrixMin, PrixMax, [Image])
			VALUES
				(@nom, @description, @heureOuverture, @heureFermeture, @lienSiteWeb, @adresseId, @typeDePaiement, @prixMin, @prixMax, @image)
	END
