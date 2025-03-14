CREATE PROCEDURE [dbo].[SP_Tag_GetById]
	@Tag_Id UNIQUEIDENTIFIER
AS
BEGIN
	SELECT	[Tag_Id],
			[Nom], 
			[Description]
			
		FROM [Tag]
	WHERE [Tag_Id] = @Tag_Id
END

