CREATE PROCEDURE [dbo].[Create_Planning]
	@date datetime2 (7),
	@heureDebut datetime,
	@heureFin datetime,
	@utilisateurID int

AS
	BEGIN
		INSERT INTO Planning([Date], HeureDebut, HeureFin, UtilisateurID)
			VALUES
				(@date, @heureDebut, @heureFin, @utilisateurID)
	END
