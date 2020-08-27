CREATE TABLE [dbo].[Utilisateur]
(
	[UtilisateurID] INT NOT NULL, 
    [Civilite] NVARCHAR(50) NOT NULL, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Prenom] NVARCHAR(50) NOT NULL,
    [Adresse] INT NOT NULL,
    [DateNaissance] DATETIME2 NOT NULL, 
    [NumTelDomicile] NVARCHAR(50) NULL, 
    [NumTelPortable] NVARCHAR(50) NOT NULL, 
    [NumFax] NVARCHAR(50) NULL, 
    [EMail] NVARCHAR(320) NOT NULL, 
    [Mdp] NVARCHAR(50) NOT NULL, 
    [GestionDroit] NVARCHAR(50) NOT NULL, 
    [Active] BIT NOT NULL, 
    CONSTRAINT [PK_Utilisateur] PRIMARY KEY ([UtilisateurID]), 
    CONSTRAINT [FK_Utilisateur_ToAdresse] FOREIGN KEY ([Adresse]) REFERENCES [Adresse](AdresseID)

    
)
