CREATE PROCEDURE [dbo].[SP_Utilisateur_Delete]
		@Utilisateur_Id UNIQUEIDENTIFIER
AS
BEGIN
	
	UPDATE [Utilisateur]
		SET [Date_Desactivation]= GETDATE()
		WHERE [Utilisateur_Id] = @Utilisateur_Id;
END
