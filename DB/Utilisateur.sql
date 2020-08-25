CREATE TABLE [dbo].[Utilisateur]
(
	[UtilisateurID] INT NOT NULL, 
    [Civilite] NVARCHAR(50) NOT NULL, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Prenom] NVARCHAR(50) NOT NULL,
    [Adresse] NVARCHAR(320) NOT NULL,
    [DateNaissance] DATETIME2 NOT NULL, 
    [NumTelDomicile] NVARCHAR(50) NOT NULL, 
    [NumTelPortable] NVARCHAR(50) NOT NULL, 
    [NumFax] NVARCHAR(50) NOT NULL, 
    [EMail] NVARCHAR(320) NOT NULL, 
    [Mdp] NVARCHAR(50) NOT NULL, 
    [GestionDroit] NVARCHAR(50) NOT NULL, 
    [Active] BIT NOT NULL, 
    CONSTRAINT [PK_Utilisateur] PRIMARY KEY ([UtilisateurID]), 
    CONSTRAINT [FK_Utilisateur_adresse] FOREIGN KEY ([Adresse]) REFERENCES Adresse(AdresseID)
    
)
