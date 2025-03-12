CREATE PROCEDURE [dbo].[SP_User_CheckPassword]
	@email NVARCHAR (320),
	@password NVARCHAR (32)
AS
BEGIN
	SELECT [Utilisateur_Id], [Pseudo]
		FROM [Utilisateur]
		WHERE [Email]=@email
			AND [Password]=[dbo].[SF_SaltAndHash](@password,[Salt])
END
