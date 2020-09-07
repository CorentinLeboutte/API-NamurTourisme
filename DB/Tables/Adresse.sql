CREATE TABLE [dbo].[Adresse]
(
	[AdresseID] INT Identity NOT NULL, 
    [Longitude] NVARCHAR(50) NOT NULL, 
    [Latitude] NVARCHAR(50) NOT NULL, 
    [Rue] NVARCHAR(300) NULL, 
    [Numero] NVARCHAR(10) NULL, 
    [Boite] NVARCHAR(5) NULL,
    [CodePostal] INT NULL, 
    [Ville] NVARCHAR(50) NULL, 
    [Region] NVARCHAR(50) NULL, 
    [Pays] NVARCHAR(50) NULL, 
    [isActive] BIT default 1  NOT NULL, 
    CONSTRAINT [PK_Adresse] PRIMARY KEY ([AdresseID]) 
)
