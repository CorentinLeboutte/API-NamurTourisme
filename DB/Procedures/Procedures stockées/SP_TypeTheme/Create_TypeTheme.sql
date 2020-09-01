CREATE PROCEDURE [dbo].[Create_TypeTheme]
	@nom nvarchar(50)

AS
	BEGIN
		INSERT INTO TypeTheme(Nom)
			VALUES
				(@nom)
	END