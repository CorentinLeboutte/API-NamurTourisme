CREATE TABLE [dbo].[Planning]
(
	[PanningID] INT NOT NULL, 
    [Date] NCHAR(10) NOT NULL, 
    [HeureDebut] NCHAR(10) NOT NULL, 
    [HeureFin] NCHAR(10) NOT NULL, 
    [OrganisateurID] NCHAR(10) NOT NULL, 
    [UtilisateurID] NCHAR(10) NOT NULL, 
    CONSTRAINT [PK_Planning] PRIMARY KEY ([PanningID]) 
)
