CREATE PROCEDURE [dbo].[SP_Utilisateur_Insert]
	@email NVARCHAR (320),
	@password NVARCHAR (32),
	@Pseudo NVARCHAR (64)
AS
BEGIN
	DECLARE @salt UNIQUEIDENTIFIER
	SET @salt=NEWID()
	INSERT INTO [Utilisateur]([Email],[Password],[Salt],[Pseudo])
	OUTPUT [inserted].[Utilisateur_Id]
	VALUES (@email,[dbo].[SF_SaltAndHash](@password,@salt),@salt,@Pseudo )
END
