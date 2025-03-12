/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
-- Script Post-Déploiement : Insertion de 5 utilisateurs
BEGIN TRY
    -- Insérer l'utilisateur 1
    EXEC [dbo].[SP_Utilisateur_Insert]
        @email = N'john.doe@example.com',
        @password = N'Password123',
        @Pseudo = N'John';

    -- Insérer l'utilisateur 2
    EXEC [dbo].[SP_Utilisateur_Insert]
        @email = N'jane.smith@example.com',
        @password = N'Password456',
        @Pseudo = N'Jane';

    -- Insérer l'utilisateur 3
    EXEC [dbo].[SP_Utilisateur_Insert]
        @email = N'peter.jones@example.com',
        @password = N'Password789',
        @Pseudo = N'Peter';

    PRINT 'Les utilisateurs ont été insérés avec succès.';
END TRY
BEGIN CATCH
    PRINT 'Une erreur est survenue lors de linsertion des utilisateurs.';
    -- Affichage des informations de l'erreur
    PRINT ERROR_MESSAGE();
END CATCH;





