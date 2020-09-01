CREATE PROCEDURE [dbo].[Update_TypeTheme]
	@typeThemeID int,
	@nom nvarchar(50)

AS
	
	BEGIN
		UPDATE TypeTheme SET 
		Nom = @nom

		WHERE TypeThemeID = @typeThemeID

	END
