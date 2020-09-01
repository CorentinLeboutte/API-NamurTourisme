CREATE PROCEDURE [dbo].[Create_PlanningTheme]
	@planningID int,
	@themeID int
AS
	BEGIN
		INSERT INTO PlanningTheme (PlanningID, ThemeID)
			
			VALUES
				(@planningID, @themeID)
	END
