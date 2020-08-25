CREATE TABLE [dbo].[Adresse]
(
	[AdresseID] INT NOT NULL, 
    [Longitude] NVARCHAR(50) NOT NULL, 
    [Latitude] NVARCHAR(50) NOT NULL, 
    [Rue] NVARCHAR(300) NOT NULL, 
    [Numero] INT NOT NULL, 
    [Boite] NVARCHAR(5) NOT NULL,
    [CodePostal] INT NOT NULL, 
    [Ville] NVARCHAR(50) NOT NULL, 
    [Region] NVARCHAR(50) NULL, 
    [Pays] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Adresse] PRIMARY KEY ([AdresseID]) 
)
