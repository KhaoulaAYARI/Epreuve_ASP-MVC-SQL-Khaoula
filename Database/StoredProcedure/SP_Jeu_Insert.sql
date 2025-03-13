CREATE PROCEDURE [dbo].[SP_Jeu_Insert]
	@nom NVARCHAR(64),
	@description NVARCHAR(512),
	@AgeMin INT,
	@AgeMax INT,
	@Nombre_Joueur_Min INT,
	@Nombre_Joueur_Max INT,
	@Duree_Minute INT,
	@Date_Creation DATETIME,
	@utilisateur_id UNIQUEIDENTIFIER
AS
BEGIN
	INSERT INTO [Jeu] ([Nom],[Description],[AgeMin],[AgeMax],[Nombre_Joueur_Min],[Nombre_Joueur_Max],[Duree_Minute],[Date_Creation],[Cree_par])
		OUTPUT [inserted].[Jeu_Id]
		VALUES
			(@nom, @description, @AgeMin,@AgeMax,@Nombre_Joueur_Min ,@Nombre_Joueur_Max,@Duree_Minute ,@Date_Creation , @utilisateur_id);
END

