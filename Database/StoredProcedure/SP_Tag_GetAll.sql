CREATE PROCEDURE [dbo].[SP_Tag_GetAll]
	AS
BEGIN
	SELECT	[Tag_Id],
			[Nom], 
			[Description]
			
		FROM [Tag]
END
