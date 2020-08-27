CREATE TABLE [dbo].[Organisateur]
(
	[OrganisateurID] INT NOT NULL , 
    [Civilite] NVARCHAR(50) NOT NULL, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Prenom] NVARCHAR(50) NOT NULL, 
    [DateNaiss] DATETIME2 NOT NULL, 
    [NumTelDomicile] NVARCHAR(50) NOT NULL, 
    [NumTelPortable] NVARCHAR(50) NOT NULL, 
    [NumFax] NVARCHAR(50) NOT NULL, 
    [EMail] NVARCHAR(320) NOT NULL, 
    [Mdp] NVARCHAR(50) NOT NULL, 
    [GestionDroit] NVARCHAR(50) NOT NULL, 
    [Active] BIT NOT NULL, 
    [Adresse] INT NOT NULL, 
    CONSTRAINT [PK_Organisateur] PRIMARY KEY ([OrganisateurID]),
    CONSTRAINT [FK_Organisateur_ToAdresse] FOREIGN KEY ([Adresse]) REFERENCES [Adresse](AdresseID)
)




