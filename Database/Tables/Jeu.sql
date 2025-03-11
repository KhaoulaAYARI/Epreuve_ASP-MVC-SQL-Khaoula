CREATE TABLE [dbo].[Jeu]
(
	[Jeu_Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	[Nom]  NVARCHAR(64) NOT NULL,
	[Description] NVARCHAR(512) NOT NULL,
	[AgeMin] INT NOT NULL,
	[AgeMax] INT NOT NULL,
	[Nombre_Joueur_Min] INT NOT NULL,
	[Nombre_Joueur_Max] INT NOT NULL,
	[Duree_Minute] INT,
	[Date_Creation] DATETIME NOT NULL DEFAULT GETDATE(),
	[Cree_par] UNIQUEIDENTIFIER,
	CONSTRAINT CK_NbJoueur CHECK ([Nombre_Joueur_Min]<=[Nombre_Joueur_Max]),
	CONSTRAINT CK_AgeJoueur CHECK ([AgeMin]<[AgeMax]),
	CONSTRAINT FK_UtilisateurCreateur FOREIGN KEY ([Cree_par]) REFERENCES [Utilisateur] ([Utilisateur_Id]) ON DELETE SET NULL

)
