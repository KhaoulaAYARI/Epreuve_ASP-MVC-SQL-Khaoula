CREATE TABLE [dbo].[Emprunt]
(
	[Emprunt_Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	[Date_Emprunt] DATETIME NOT NULL DEFAULT GETDATE(),
	[Date_Retour] DATETIME,
	[Evaluation_Preteur] INT,
	[Evaluation_Emprunteur] INT,
	[Jeu_Id] UNIQUEIDENTIFIER,
	[Preteur_Id] UNIQUEIDENTIFIER NOT NULL,
	[Emprunteur_Id] UNIQUEIDENTIFIER NOT NULL,
	[Collection_Id] UNIQUEIDENTIFIER NOT NULL,
	CONSTRAINT CK_EvaluationPreteur CHECK ([Evaluation_Preteur] IS NULL OR [Evaluation_Preteur] BETWEEN 0 AND 5),
	CONSTRAINT CK_EvaluationEmprunteur CHECK ([Evaluation_Emprunteur] IS NULL OR [Evaluation_Emprunteur] BETWEEN 0 AND 5),
	CONSTRAINT FK_JeuEmprunt FOREIGN KEY ([Jeu_Id]) REFERENCES [Jeu] ([Jeu_Id]) ON DELETE SET NULL,
	CONSTRAINT FK_Emprunteur FOREIGN KEY ([Emprunteur_Id]) REFERENCES [Utilisateur] ([Utilisateur_Id]) ON DELETE SET NULL,
	CONSTRAINT FK_Preteur FOREIGN KEY ([Preteur_Id]) REFERENCES [Collection] ([Utilisateur_Id]) ON DELETE SET NULL,



)
