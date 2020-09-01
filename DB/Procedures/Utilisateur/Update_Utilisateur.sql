CREATE PROCEDURE [dbo].[Update_Utilisateur]
	@utilisateurID int,
	@nom nvarchar(50),
	@prenom nvarchar(50),
	@adresseID int,
	@dateNaiss datetime2(7),
	@numTelDomicile nvarchar(50),
	@numTelPortable nvarchar(50),
	@numFax nvarchar(50),
	@email nvarchar(320),
	@mdp nvarchar(50),
	@isAdmin bit

AS
	
	BEGIN
		UPDATE Utilisateur SET 
		Nom = @nom,
		Prenom = @prenom,
		AdresseId = @adresseID,
		DateNaissance = @dateNaiss,
		NumTelDomicile = @numTelDomicile,
		NumTelPortable = @numTelPortable,
		NumFax = @numFax,
		EMail = @email,
		Mdp = @mdp,
		isAdmin = @isAdmin

		WHERE UtilisateurID = @utilisateurID

	END
