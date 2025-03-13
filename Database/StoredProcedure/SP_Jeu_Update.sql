CREATE PROCEDURE [dbo].[SP_Jeu_Update]
	@jeu_id UNIQUEIDENTIFIER,
	@nom NVARCHAR(64),
	@description NVARCHAR(512),
	@AgeMin INT,
	@AgeMax INT,
	@Nombre_Joueur_Min INT,
	@Nombre_Joueur_Max INT,
	@Duree_Minute INT,
	@Date_Creation DATETIME
AS
BEGIN
	UPDATE [Jeu]
		SET [Nom] = @nom,
			[Description] = @description,
			[AgeMin] = @AgeMin,
			[AgeMax]=@AgeMax,
			[Nombre_Joueur_Min]=@Nombre_Joueur_Min,
			[Nombre_Joueur_Max]=@Nombre_Joueur_Max,
			[Duree_Minute]=@Duree_Minute

		WHERE [Jeu_Id] = @jeu_id
END
