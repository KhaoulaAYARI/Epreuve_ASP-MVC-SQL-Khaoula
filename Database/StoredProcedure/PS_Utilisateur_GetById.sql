CREATE PROCEDURE [dbo].[PS_Utilisateur_GetById]
	@Utilisateur_Id UNIQUEIDENTIFIER
AS
BEGIN
	SELECT [Utilisateur_Id],
			[Email],
			[Pseudo],
			[Date_Creation],
			[Date_Desactivation]
		FROM [Utilisateur]
		WHERE [Utilisateur_Id]=@Utilisateur_Id
END