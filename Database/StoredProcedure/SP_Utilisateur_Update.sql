CREATE PROCEDURE [dbo].[SP_Utilisateur_Update]
	@Utilisateur_Id UNIQUEIDENTIFIER,
	@Email NVARCHAR (320),
	@Pseudo NVARCHAR (64)
AS
BEGIN
	UPDATE [Utilisateur]
				SET [Pseudo]=@Pseudo
				WHERE [Utilisateur_Id]=@Utilisateur_Id
END