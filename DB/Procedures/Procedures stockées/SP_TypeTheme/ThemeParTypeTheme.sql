CREATE PROCEDURE [dbo].[ThemeParTypeTheme]
	@TypeThemeID int
AS
select T.*,TT.Nom from TypeTheme TT join ThemeTypeTheme TTT on TT.TypeThemeID = TTT.TypeThemeID join Theme T on t.ThemeID = TTT.ThemeID  where TT.TypeThemeID = @TypeThemeID