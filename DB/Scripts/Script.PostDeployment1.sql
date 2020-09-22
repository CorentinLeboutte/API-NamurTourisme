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

('blabla','blabla','Rue machin','85',NULL,'Namur',5000,NULL, 'Belgique'),

('50°N','4°E','Rue Charles Simon','26',NULL,'Namur',5004,NULL,'Belgique'),

('blabla','blabla','Rue hello','74',NULL,'Charleroi',6000,NULL, 'Belgique');



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

INSERT INTO Theme (Nom,[Description],HeureOuverture,HeureFermeture,LienSiteWeb, AdresseID,TypeDePaiement, PrixMin, PrixMax)

VALUES

('Citadelle de Namur','La citadelle de Namur, en Belgique, est une ancienne place forte dominant la ville et le confluent. Il s''agit d''une des plus grandes citadelles
d''Europe et son vaste réseau de souterrains lui valut d''être surnommée "La termitière de l''Europe" par Napoléon Iᵉʳ.','09:00:00','19:00:00','https://citadelle.namur.be/fr',1,'Liquide, Bancontact, visa',5,12),

('Musee Felicien Rops','Peintures, gravures, dessins et lettres de l''artiste belge du 19e siècle dans un ancien hôtel de maître.','10:00:00','18:00:00','https://www.museerops.be/',1,'Liquide, Bancontact',5,10);

/*PLANNING*/

INSERT INTO Planning([Date],HeureDebut,HeureFin,UtilisateurID,isActive)

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




