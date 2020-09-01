CREATE PROCEDURE [dbo].[Update_Planning]
	@planningID int,
	@date datetime2(7),
	@heureDebut datetime,
	@heureFin datetime,
	@utilisateurID int


AS
	
	BEGIN
		UPDATE Planning SET 
		PlanningID = @planningID,
		[Date] = @date,
		HeureDebut = @heureDebut,
		HeureFin = @heureFin,
		UtilisateurID = @utilisateurID

		WHERE PlanningID = @planningID

	END