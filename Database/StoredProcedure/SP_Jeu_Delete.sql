CREATE PROCEDURE [dbo].[SP_Jeu_Delete]
	@jeu_id UNIQUEIDENTIFIER
AS
BEGIN
	DELETE 
		FROM [Jeu]
		WHERE [Jeu_Id] = @jeu_id
END
