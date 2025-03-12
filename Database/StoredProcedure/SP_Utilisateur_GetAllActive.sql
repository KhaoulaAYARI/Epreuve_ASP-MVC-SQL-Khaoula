CREATE PROCEDURE [dbo].[SP_Utilisateur_GetAllActive]

AS
BEGIN 
	SELECT [Utilisateur_Id],
			[Email],
			[Pseudo],
			[Date_Creation]
		FROM [Utilisateur]
		WHERE [Date_Desactivation] IS NULL
END
