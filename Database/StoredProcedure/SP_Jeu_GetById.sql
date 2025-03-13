CREATE PROCEDURE [dbo].[SP_Jeu_GetById]
	@Jeu_Id UNIQUEIDENTIFIER
AS
BEGIN
	SELECT	[Jeu_Id],
			[Nom], 
			[Description],
			[AgeMin],
			[AgeMax],
			[Nombre_Joueur_Min],
			[Nombre_Joueur_Max],
			[Duree_Minute],
			[Date_Creation],
			[Cree_par]
		FROM [Jeu]
	WHERE [Jeu_Id] = @Jeu_Id
END
