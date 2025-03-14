CREATE PROCEDURE [dbo].[SP_Tag_Update]
	@Tag_Id UNIQUEIDENTIFIER,
	@nom NVARCHAR(64),
	@description NVARCHAR(512)
AS
BEGIN
	UPDATE [Tag]
				SET [nom]=@nom
				WHERE [description]=@description
END
