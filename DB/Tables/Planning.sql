CREATE TABLE [dbo].[Planning]
(
	[PlanningID] INT Identity NOT NULL , 
    [Date] DATETIME2 NOT NULL, 
    [HeureDebut] DATETIME NOT NULL, 
    [HeureFin] DATETIME NOT NULL,  
    [UtilisateurID] INT NOT NULL, 
    [isActive] BIT default 1 NOT NULL, 
    CONSTRAINT [PK_Planning] PRIMARY KEY ([PlanningID]),
    CONSTRAINT [FK_Planning_ToUtilisateur] FOREIGN KEY ([UtilisateurID]) REFERENCES [Utilisateur]([UtilisateurID])
)

