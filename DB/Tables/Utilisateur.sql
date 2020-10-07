CREATE TABLE [dbo].[Utilisateur]
(
	[UtilisateurID] INT Identity NOT NULL, 
    [Civilite] NVARCHAR(50) NOT NULL, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Prenom] NVARCHAR(50) NOT NULL,
    [AdresseID] INT NOT NULL,
    [DateNaiss] DATETIME2 NOT NULL, 
    [NumTelDomicile] NVARCHAR(50) NULL, 
    [NumTelPortable] NVARCHAR(50) NOT NULL, 
    [NumFax] NVARCHAR(50) NULL, 
    [EMail] NVARCHAR(320) NOT NULL, 
    [Mdp] NVARCHAR(50) NOT NULL, 
    [isAdmin] BIT  default 0 NOT NULL, 
    [isActive] BIT default 1  NOT NULL, 
    CONSTRAINT [PK_Utilisateur] PRIMARY KEY ([UtilisateurID]), 
    CONSTRAINT [FK_Utilisateur_ToAdresse] FOREIGN KEY ([AdresseID]) REFERENCES [Adresse](AdresseID),
    CONSTRAINT [UK_Utilisateur_EMail] UNIQUE ([EMail])

    
)
