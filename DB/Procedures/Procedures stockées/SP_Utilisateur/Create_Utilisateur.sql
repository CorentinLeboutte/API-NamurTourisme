CREATE PROCEDURE [dbo].[Create_Utilisateur]
	@civilite nvarchar(50),
	@nom nvarchar(50),
	@prenom nvarchar(50),
	@adresseId int,
	@dateNaiss datetime2(7),
	@numTelDomicile nvarchar(50),
	@numTelPortable nvarchar(50),
	@numFax nvarchar(50),
	@eMail nvarchar(320),
	@mdp nvarchar(50)

AS
	BEGIN
		INSERT INTO Utilisateur (Civilite, Nom, Prenom, AdresseId, DateNaiss, NumTelDomicile, NumTelPortable, NumFax, EMail,Mdp)
			VALUES
				(@civilite, @nom, @prenom, @adresseId, @dateNaiss, @numTelDomicile,@numTelPortable, @numFax, @eMail, @mdp)
	END
