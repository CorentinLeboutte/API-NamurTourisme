/*UTILIATEUR */

EXEC dbo.Create_Utilisateur 
'test','test','test',1,'2000-01-01','test','test','test','test','test=1234='

EXEC dbo.Update_Utilisateur
5,'Blabla','test',1,'2000-01-01','test','test','test','test','test=1234=', 0

EXEC dbo.Delete_Utilisateur 5

SELECT * FROM Utilisateur WHERE isActive = 0

SELECT * FROM Utilisateur WHERE isActive = 1

/****************** OK*********************/

/*TYPETHEME*/

EXEC dbo.Create_TypeTheme 'test'

EXEC dbo.Update_TypeTheme 4,'blabla'

EXEC dbo.Delete_TypeTheme 4

SELECT * FROM TypeTheme 

/*****************OK*******************/

/*THEMETYPETHEME*/

EXEC dbo.Create_ThemeTypeTheme 1,1
EXEC dbo.Create_ThemeTypeTheme 1,2
EXEC dbo.Create_ThemeTypeTheme 2,2
EXEC dbo.Create_ThemeTypeTheme 1,3

EXEC dbo.Delete_ThemeTypeTheme_OneByOne 1,1

EXEC dbo.Delete_ThemeTypeTheme_Theme 1

EXEC dbo.Delete_ThemeTypeTheme_TypeTheme 2

SELECT * FROM ThemeTypeTheme


/****************** NOK ******************/

/*PLANNINGTHEME*/

EXEC dbo.Create_PlanningTheme 1,1

EXEC dbo.Delete_PlanningTheme_OneByOne

EXEC dbo.Delete_PlanningTheme_Planning

EXEC dbo.Delete_PlanningTheme_Theme




/********************* OK *****************/

/*THEME*/

EXEC dbo.Create_Theme   'Capitainerie','Super cool acti','1900-01-01 09:00:00.000','1900-01-01 21:00:00.000', 'www.capitainerie.be',1

EXEC dbo.Update_Theme

EXEC dbo.Delete_Theme

SELECT * FROM Theme

SELECT Nom, [Description], cast(HeureOuverture as time(0)) FROM Theme



/******************** OK **********************/

PLANNING

EXEC dbo.Create_Planning   '2020-01-05','09:00:00','21:00:00',1

EXEC dbo.Update_Planning

EXEC dbo.Delete_Planning

SELECT * FROM Planning

/********************* OK *********************/

ADRESSE

EXEC dbo.Create_Adresse   '56464','456456','Rue de la liberté','12',NULL,'Charleroi','6000', NULL,'Belgique'

EXEC dbo.Update_Adresse 2,'56464','456456','Rue de la liberté','12',NULL,'Namur','5004', NULL,'Belgique'

EXEC dbo.Delete_Adresse 3

SELECT * FROM Adresse




