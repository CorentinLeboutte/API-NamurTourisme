CREATE TABLE [dbo].[ThemeTypeThee]
(
	[ThemeID] INT NOT NULL, 
    TypeThemeID INT NOT NULL,
	CONSTRAINT [PK_TypeThemeTheme] PRIMARY KEY ([ThemeID], TypeThemeID) ,
	CONSTRAINT [FK_TypeThemeTheme_ToTheme] FOREIGN KEY (ThemeID) REFERENCES [Theme](ThemeID),
	CONSTRAINT [FK_TypeThemeTheme_ToTypeTheme] FOREIGN KEY (TypeThemeID) REFERENCES TypeTheme(TypeThemeID)
)



