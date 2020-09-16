CREATE TABLE [dbo].[Avis]
(
	[AvisID] INT identity  NOT NULL, 
    [UtilisateurID] INT NOT NULL, 
    [ThemeID] INT NOT NULL, 
    [Note] INT NULL, 
    [Commentaire] NVARCHAR(320) NOT NULL, 
    [DateCommentaire] DATETIME2 NOT NULL, 
    [isActive] BIT NOT NULL DEFAULT 1, 

    CONSTRAINT [PK_AvisID] PRIMARY KEY (AvisID,[UtilisateurID], ThemeID),
	CONSTRAINT [FK_UtilisateurTheme_ToUtilisateur] FOREIGN KEY (UtilisateurID) REFERENCES [Utilisateur](UtilisateurID),
	CONSTRAINT [FK_UtilisateurTheme_ToTheme] FOREIGN KEY (ThemeID) REFERENCES [Theme](ThemeID)
)

