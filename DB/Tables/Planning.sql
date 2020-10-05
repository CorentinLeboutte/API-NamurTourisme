﻿CREATE TABLE [dbo].[Planning]
(
	[PlanningID] INT NOT NULL IDENTITY, 
    [Date] NCHAR(10) NOT NULL, 
    [HeureDebut] NCHAR(10) NOT NULL, 
    [HeureFin] NCHAR(10) NOT NULL, 
    [OrganisateurID] NCHAR(10) NOT NULL, 
    [UtilisateurID] NCHAR(10) NOT NULL, 
    [isActive] BIT NOT NULL DEFAULT 1, 
    CONSTRAINT [PK_Planning] PRIMARY KEY ([PlanningID]) 
)