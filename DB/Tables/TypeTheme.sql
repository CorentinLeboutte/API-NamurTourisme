CREATE TABLE [dbo].[TypeTheme]
(
	[TypeThemeID] INT Identity NOT NULL , 
    [Nom] NVARCHAR(50) NOT NULL,
    [isActive] BIT default 1  NOT NULL, 
    CONSTRAINT [PK_TypeTheme] PRIMARY KEY ([TypeThemeID])
)

