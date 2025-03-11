CREATE TABLE [dbo].[Collection]
(
	[Collection_Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	[Utilisateur_Id] UNIQUEIDENTIFIER NOT NULL,
	[Jeu_Id] UNIQUEIDENTIFIER NOT NULL,
	[Etat] NVARCHAR(16) NOT NULL,
	CONSTRAINT FK_UtilisateurCollection FOREIGN KEY ([Utilisateur_Id]) REFERENCES [Utilisateur] ([Utilisateur_Id]) ON DELETE CASCADE,
	CONSTRAINT FK_JeuCollection FOREIGN KEY ([Jeu_Id]) REFERENCES [Jeu] ([Jeu_Id]) ON DELETE CASCADE,
	CONSTRAINT CK_Etat CHECK ([Etat] IN ('Neuf','Abimé','Incomplet'))

)
