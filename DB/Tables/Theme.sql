CREATE TABLE [dbo].[Theme]
(
	[ThemeID] INT Identity NOT NULL , 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(600) NOT NULL, 
    [HeureOuverture] DATETIME2 NULL, 
    [HeureFermeture] DATETIME2 NULL, 
    [LienSiteWeb] NVARCHAR (320) NULL, 
    [AdresseID] INT NOT NULL, 
    [isActive] BIT default 1  NOT NULL, 
    [TypeDePaiement] NVARCHAR(50) NULL, 
    [PrixMin] MONEY NULL DEFAULT 0, 
    [PrixMax] MONEY NULL DEFAULT 0, 
    CONSTRAINT [PK_Theme] PRIMARY KEY ([ThemeID]),
    CONSTRAINT [FK_Theme_ToAdresse] FOREIGN KEY ([AdresseID]) REFERENCES [Adresse]([AdresseID]), 
)
