/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
/* AJOUT ADRESSE */

INSERT INTO Adresse (Longitude, Latitude, Rue, Numero, Boite,Ville, CodePostal, Region, Pays)

VALUES 

/*1*/('blabla','blabla','Rue machin','85',NULL,'Namur',5000,NULL, 'Belgique'),

/*2*/('50°N','4°E','Rue Charles Simon','26',NULL,'Namur',5004,NULL,'Belgique'),

/*3*/('blabla','blabla','Rue hello','74',NULL,'Charleroi',6000,NULL, 'Belgique'),

/*4*/('50°27''43.2"N','4°51''54.1"E','rue des Brasseurs','61',NULL,'Namur',5000,NULL, 'Belgique'),

/*5*/('50°27''23.7"N','4°52''18.3"E','Avenue du Bourgmestre Jean Materne','123',NULL,'Namur',5000,NULL, 'Belgique'),

/*6*/('50°26''41.5"N','4°52''18.3"E','Avenue du Bourgmestre Jean Materne','123',NULL,'Namur',5000,NULL, 'Belgique');








/* AJOUT UTILISATEUR */

INSERT INTO Utilisateur(Civilite, Nom, Prenom, DateNaiss, NumTelDomicile, NumTelPortable, NumFax, EMail, Mdp, isAdmin, isActive, AdresseId)

VALUES 

('Mademoiselle','Ruais','Adélaïde','1983-10-24',NULL,'0496 68 26 84',NULL,'AdelaideRuais@rhyta.com', HASHBYTES('SHA2_512', dbo.PreSalt()+'test1234'+dbo.PostSalt()),DEFAULT,DEFAULT,1),

('Monsieur','Blanc','Percy','1977-06-27',NULL,'0498 72 78 86',NULL,'PercyBlanc@armyspy.com',HASHBYTES('SHA2_512', dbo.PreSalt()+'test1234'+dbo.PreSalt()),DEFAULT,DEFAULT,2),

('Monsieur','Ménard','Pascal','1991-01-24','071 24 51 65','0475 51 48 79','071 24 51 66','jc.vandamme@biceps.com',HASHBYTES('SHA2_512', dbo.PreSalt()+'test1234'+dbo.PreSalt()),DEFAULT,DEFAULT,3),

('Mademoiselle','Labrecque','Ancelina','1957-07-20',NULL,'0477 78 23 20',NULL,'AncelinaCaouette@dayrep.com',HASHBYTES('SHA2_512', dbo.PreSalt()+'test1234'+dbo.PreSalt()),DEFAULT,DEFAULT,1);


/* AJOUT ORGANISATEUR */

INSERT INTO Utilisateur(Civilite, Nom, Prenom, DateNaiss, NumTelDomicile, NumTelPortable, NumFax, EMail, Mdp, isAdmin, isActive, AdresseId)

VALUES 

('Monsieur','Leboutte','Corentin','1989-08-09',NULL,'0498 26 21 62',NULL,'corentin.leboutte@live.be',HASHBYTES('SHA2_512', dbo.PreSalt()+'test1234'+dbo.PreSalt()),1,DEFAULT,1);

/*AJOUT TYPE THEME*/

INSERT INTO TypeTheme(Nom)

VALUES

('Visites'),
('Gastronomie'),
('Divertissement');

/*AJOUT THEME */

INSERT INTO Theme (Nom,[Description],HeureOuverture,HeureFermeture,LienSiteWeb, AdresseID,TypeDePaiement, PrixMin, PrixMax,[Image])

VALUES

/*1*/('Citadelle de Namur','La citadelle de Namur, en Belgique, est une ancienne place forte dominant la ville et le confluent. Il s''agit d''une des plus grandes citadelles
d''Europe et son vaste réseau de souterrains lui valut d''être surnommée "La termitière de l''Europe" par Napoléon Iᵉʳ.','09:00:00','19:00:00','https://citadelle.namur.be/fr',1,'Liquide, Bancontact, visa',5,12,'https://ibb.co/VtFc74V'),

/*2*/('Musee Felicien Rops','Peintures, gravures, dessins et lettres de l''artiste belge du 19e siècle dans un ancien hôtel de maître.','10:00:00','18:00:00','https://www.museerops.be/',1,'Liquide, Bancontact',5,10,'https://i.ibb.co/Bj4dmLp/Rops1.jpg'),




/*3*/('VinoVino','Le sympathique patron vous demandera d’emblée ce que vous aimeriez boire. C’est qu’il vous réserve des petites perles de vins surtout européens. Mais on ne résiste pas non plus à une belle planche de fromage ou à un plat plus recherché, car les produits tiennent le haut de l’affiche. Le plaisir de la tradition, en toute simplicité.','10:00:00','18:00:00','http://www.vinovino.be/',4,'Liquide, Bancontact, Mastercard, Visa',25,50,'https://i.ibb.co/P6g71Zr/VinoVino.png'),

/*4*/('Le Binôme','Le sympathique patron vous demandera d’emblée ce que vous aimeriez boire. C’est qu’il vous réserve des petites perles de vins surtout européens. Mais on ne résiste pas non plus à une belle planche de fromage ou à un plat plus recherché, car les produits tiennent le haut de l’affiche. Le plaisir de la tradition, en toute simplicité.','10:00:00','18:00:00','http://www.lebinome.be/',5,'Liquide, Bancontact, Mastercard, Visa',16,37,'https://i.ibb.co/BqMCsG2/Binome.jpg'),

/*5*/('Attablez-vous','Installez-vous dans votre confortable fauteuil design, admirez la salle à manger, chic aux accents colorés, et attendez-vous à être choyé. La gourmandise passe avant tout chez Charles-Edouard Jeandrain. Vous trouverez ici des gels et des espumas, mais seulement si cela est utile. Sa cuisine est pure, bien pensée et travaillée. Un savoir-faire qui vous rend heureux !','10:00:00','18:00:00','http://www.attablezvous.be/',1,'Liquide, Bancontact, Mastercard, Visa',25,50,'https://i.ibb.co/Bj4dmLp/Rops1.jpg'),

/*6*/('Bistro Belgo Belge','Situé au cœur de Namur, vous trouverez dans cet établissement des préparations maison, des plats et des viandes ...','10:00:00','18:00:00','https://www.estaminetbbb.be/',1,'Liquide, Bancontact, Mastercard, Visa',25,50,'https://i.ibb.co/P6g71Zr/VinoVino.png'),

/*7*/('VinoVino','Le sympathique patron vous demandera d’emblée ce que vous aimeriez boire. C’est qu’il vous réserve des petites perles de vins surtout européens. Mais on ne résiste pas non plus à une belle planche de fromage ou à un plat plus recherché, car les produits tiennent le haut de l’affiche. Le plaisir de la tradition, en toute simplicité.','10:00:00','18:00:00','http://www.vinovino.be/',1,'Liquide, Bancontact, Mastercard, Visa',25,50,'https://i.ibb.co/P6g71Zr/VinoVino.png'),

/*8*/('VinoVino','Le sympathique patron vous demandera d’emblée ce que vous aimeriez boire. C’est qu’il vous réserve des petites perles de vins surtout européens. Mais on ne résiste pas non plus à une belle planche de fromage ou à un plat plus recherché, car les produits tiennent le haut de l’affiche. Le plaisir de la tradition, en toute simplicité.','10:00:00','18:00:00','http://www.vinovino.be/',1,'Liquide, Bancontact, Mastercard, Visa',25,50,'https://i.ibb.co/P6g71Zr/VinoVino.png'),

/*9*/('VinoVino','Le sympathique patron vous demandera d’emblée ce que vous aimeriez boire. C’est qu’il vous réserve des petites perles de vins surtout européens. Mais on ne résiste pas non plus à une belle planche de fromage ou à un plat plus recherché, car les produits tiennent le haut de l’affiche. Le plaisir de la tradition, en toute simplicité.','10:00:00','18:00:00','http://www.vinovino.be/',1,'Liquide, Bancontact, Mastercard, Visa',25,50,'https://i.ibb.co/P6g71Zr/VinoVino.png'),

/*10*/('VinoVino','Le sympathique patron vous demandera d’emblée ce que vous aimeriez boire. C’est qu’il vous réserve des petites perles de vins surtout européens. Mais on ne résiste pas non plus à une belle planche de fromage ou à un plat plus recherché, car les produits tiennent le haut de l’affiche. Le plaisir de la tradition, en toute simplicité.','10:00:00','18:00:00','http://www.vinovino.be/',1,'Liquide, Bancontact, Mastercard, Visa',25,50,'https://i.ibb.co/P6g71Zr/VinoVino.png');



/*PLANNING*/

INSERT INTO Planning([Date],HeureDebut,HeureFin,OrganisateurID,UtilisateurID)

VALUES
('2020-06-15','10:00:00','18:00:00',1,1),
('2020-06-15','09:00:00','19:00:00',1,1),
('2020-06-16','10:00:00','15:00:00',1,1),
('2020-06-17','10:00:00','18:00:00',1,1),
('2020-06-17','08:00:00','17:00:00',1,1),
('2020-06-17','08:00:00','19:00:00',1,1),
('2020-06-18','08:00:00','18:00:00',1,1),
('2020-06-19','10:00:00','19:00:00',1,1),
('2020-06-19','09:00:00','19:00:00',1,1);

/*AVIS*/

INSERT INTO Avis(UtilisateurID,ThemeID,Note,Commentaire,DateCommentaire)

VALUES
(1,2,4,'Très très bien','2020-06-15'),
(2,2,5,'Génial','2020-06-14'),
(3,2,2,'pas top','2020-06-17');

/*MTM PlanningTheme */

Insert Into PlanningTheme(PlanningID,ThemeID)

Values
('1','1'),
('2','2'),
('3','2'),
('4','2'),
('5','1'),
('6','1'),
('7','2');



/*MTM ThemeTypeTheme*/

Insert into ThemeTypeTheme(ThemeID,TypeThemeID)

values

('1','3'),
('2','1'),
('3','2'),
('4','2'),
('5','2'),
('6','2'),
('7','2'),
('8','2'),
('9','2'),
('10','2');




