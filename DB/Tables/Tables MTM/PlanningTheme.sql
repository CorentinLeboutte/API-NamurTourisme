CREATE TABLE [dbo].[PlanningTheme]
(
	[PlanningID] INT NOT NULL , 
    [ThemeID] INT NOT NULL, 
    CONSTRAINT [PK_ThemeID] PRIMARY KEY ([PlanningID], ThemeID) ,
	CONSTRAINT [FK_PlanningTheme_ToPlanning] FOREIGN KEY (PlanningID) REFERENCES [Planning](PlanningID),
	CONSTRAINT [FK_PlanningTheme_ToTheme] FOREIGN KEY (ThemeID) REFERENCES [Theme](ThemeID)
)

