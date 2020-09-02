CREATE TABLE [dbo].[Theme]
(
	[ThemeID] INT Identity NOT NULL , 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(320) NOT NULL, 
    [HeureOuverture] DATETIME NOT NULL, 
    [HeureFermeture] DATETIME NOT NULL, 
    [LienSiteWeb] NVARCHAR (320) NULL, 
    [AdresseID] INT NOT NULL, 
    CONSTRAINT [PK_Theme] PRIMARY KEY ([ThemeID]),
    CONSTRAINT [FK_Theme_ToAdresse] FOREIGN KEY ([AdresseID]) REFERENCES [Adresse]([AdresseID]), 
)
