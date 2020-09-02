CREATE TABLE [dbo].[Theme]
(
	[ThemeID] INT Identity NOT NULL , 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(600) NOT NULL, 
    [HeureOuverture] DATETIME2 NULL, 
    [HeureFermeture] DATETIME2 NULL, 
    [LienSiteWeb] NVARCHAR (320) NULL, 
    [AdresseID] INT NOT NULL, 
    CONSTRAINT [PK_Theme] PRIMARY KEY ([ThemeID]),
    CONSTRAINT [FK_Theme_ToAdresse] FOREIGN KEY ([AdresseID]) REFERENCES [Adresse]([AdresseID]), 
)
