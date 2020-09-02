EXEC dbo.Create_Utilisateur 
'test','test','test',1,'2000-01-01','test','test','test','test','test=1234='

EXEC dbo.Update_Utilisateur
5,'Blabla','test',1,'2000-01-01','test','test','test','test','test=1234=', 0

EXEC dbo.Delete_Utilisateur 5

SELECT * FROM Utilisateur WHERE isActive = 0

SELECT * FROM Utilisateur WHERE isActive = 1

/***************************************/

EXEC dbo.Create_TypeTheme 'test'

EXEC dbo.Update_TypeTheme 4,'blabla'

EXEC dbo.Delete_TypeTheme 4

SELECT * FROM TypeTheme 

/************************************/

EXEC dbo.Create_ThemeTypeTheme 

EXEC dbo.Delete_ThemeTypeTheme_OneByOne

EXEC dbo.Delete_ThemeTypeTheme_Theme

EXEC dbo.Delete_ThemeTypeTheme_TypeTheme

SELECT * FROM 

