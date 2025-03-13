﻿CREATE PROCEDURE [dbo].[SP_Jeu_GetByUtilisateurId]
	@utilisateur_id UNIQUEIDENTIFIER
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
	WHERE [Cree_par] = @utilisateur_id 
END
