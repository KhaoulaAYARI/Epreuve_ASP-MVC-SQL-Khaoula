CREATE PROCEDURE [dbo].[SP_Tag_Insert]
	@nom NVARCHAR(64),
	@description NVARCHAR(512)
	AS
BEGIN
	INSERT INTO [Tag] ([Nom],[Description])
		OUTPUT [inserted].[Tag_Id]
		VALUES
			(@nom, @description);
END
