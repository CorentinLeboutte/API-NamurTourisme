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


/* AJOUT UTILISATEUR */

INSERT INTO Utilisateur(Civilite, Nom, Prenom, DateNaissance, NumTelDomicile, NumTelPortable, NumFax, EMail, Mdp, Active,Adresse)

VALUES 

('Mademoiselle','Ruais','Adélaïde','1983-10-24',NULL,'0496 68 26 84',NULL,'AdelaideRuais@rhyta.com', HASHBYTES('SHA2_512', dbo.PreSalt()+'test1234'+dbo.PreSalt,1),

('Monsieur','Senneville','Jesper','1986-08-31',NULL,'0496 68 26 84',NULL,'JesperSenneville@rhyta.com',HASHBYTES('SHA2_512', dbo.PreSalt()+'test1234'+dbo.PreSalt,1),

('Monsieur','Blanc','Percy','1977-06-27',NULL,'0498 72 78 86',NULL,'PercyBlanc@armyspy.com',HASHBYTES('SHA2_512', dbo.PreSalt()+'test1234'+dbo.PreSalt,1),

('Mademoiselle','Labrecque','Ancelina','1957-07-20',NULL,'0477 78 23 20',NULL,'AncelinaCaouette@dayrep.com',HASHBYTES('SHA2_512', dbo.PreSalt()+'test1234'+dbo.PreSalt,1);


/* AJOUT ORGANISATEUR */

INSERT INTO Organisateur( Civilite, Nom, Prenom, DateNaissance, NumTelDomicile, NumTelPortable, NumFax, EMail, Mdp, Active,Adresse)

VALUES 

('Monsieur','Leboutte','Corentin','1989-08-09',NULL,'0498 26 21 62',NULL,'corentin.leboutte@live.be',HASHBYTES('SHA2_512', dbo.PreSalt()+'test1234'+dbo.PreSalt,1);

/*AJOUT TYPE THEME*/

INSERT INTO TypeTheme(Nom)

VALUES

('Visites'),
('Gastronomie'),
('Divertissement');

/*AJOUT THEME */

INSERT INTO Theme (Nom,[Description],HeureOuverture,HeureFermeture,LienSiteWeb)

VALUES

('Citadelle de Namur','La citadelle de Namur, en Belgique, est une ancienne place forte dominant la ville et le confluent. Il s''agit d''une des plus grandes citadelles
d''Europe et son vaste réseau de souterrains lui valut d''être surnommée "La termitière de l''Europe" par Napoléon Iᵉʳ.','09:00:00','19:00:00','https://citadelle.namur.be/fr'),

('Musee Felicien Rops','Peintures, gravures, dessins et lettres de l''artiste belge du 19e siècle dans un ancien hôtel de maître.','10:00:00','18:00:00','https://www.museerops.be/');


