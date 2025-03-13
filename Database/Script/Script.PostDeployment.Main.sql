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
-- Script Post-Déploiement : Insertion de 3 utilisateurs
/*BEGIN TRY
    -- Insérer l'utilisateur 1
    EXEC [dbo].[SP_Utilisateur_Insert]
        @email = N'john.doe@example.com',
        @password = N'Password123=',
        @Pseudo = N'John';

    -- Insérer l'utilisateur 2
    EXEC [dbo].[SP_Utilisateur_Insert]
        @email = N'jane.smith@example.com',
        @password = N'Password456=',
        @Pseudo = N'Jane';

    -- Insérer l'utilisateur 3
    EXEC [dbo].[SP_Utilisateur_Insert]
        @email = N'peter.jones@example.com',
        @password = N'Password789=',
        @Pseudo = N'Peter';

    PRINT 'Les utilisateurs ont été insérés avec succès.';
END TRY
BEGIN CATCH
    PRINT 'Une erreur est survenue lors de linsertion des utilisateurs.';
    -- Affichage des informations de l'erreur
    PRINT ERROR_MESSAGE();
END CATCH;*/
-- Déclaration des GUID des utilisateurs
DECLARE @utilisateur1 UNIQUEIDENTIFIER = 'df485cc3-09cf-432c-9633-1209a82d8b74';
DECLARE @utilisateur2 UNIQUEIDENTIFIER = 'a91e641f-464a-4a28-8799-ef98a46a8b13';
DECLARE @utilisateur3 UNIQUEIDENTIFIER = '4ced6efe-4275-4711-8a0e-0c056f4dbf82';

-- Insertion de 5 jeux avec la procédure stockée SP_Jeu_Insert
/*EXEC [dbo].[SP_Jeu_Insert] 
    @nom = 'Jeu 1', 
    @description = 'Description du jeu 1', 
    @AgeMin = 12, 
    @AgeMax = 18, 
    @Nombre_Joueur_Min = 2, 
    @Nombre_Joueur_Max = 4, 
    @Duree_Minute = 30, 
    @Date_Creation = '2023-01-01', 
    @utilisateur_id = @utilisateur1;*/
EXEC [dbo].[SP_Jeu_Insert] 
    @nom = 'Jeu 2', 
    @description = 'Description du jeu 2', 
    @AgeMin = 10, 
    @AgeMax = 16, 
    @Nombre_Joueur_Min = 1, 
    @Nombre_Joueur_Max = 2, 
    @Duree_Minute = 20, 
    @Date_Creation = '2023-01-01', 
    @utilisateur_id = @utilisateur1;

EXEC [dbo].[SP_Jeu_Insert] 
    @nom = 'Jeu 3', 
    @description = 'Description du jeu 3', 
    @AgeMin = 8, 
    @AgeMax = 12, 
    @Nombre_Joueur_Min = 3, 
    @Nombre_Joueur_Max = 6, 
    @Duree_Minute = 45, 
    @Date_Creation = '2023-01-01',  
    @utilisateur_id = @utilisateur2;

EXEC [dbo].[SP_Jeu_Insert] 
    @nom = 'Jeu 4', 
    @description = 'Description du jeu 4', 
    @AgeMin = 15, 
    @AgeMax = 25, 
    @Nombre_Joueur_Min = 2, 
    @Nombre_Joueur_Max = 4, 
    @Duree_Minute = 60, 
    @Date_Creation = '2023-01-01',  
    @utilisateur_id = @utilisateur2;

EXEC [dbo].[SP_Jeu_Insert] 
    @nom = 'Jeu 5', 
    @description = 'Description du jeu 5', 
    @AgeMin = 18, 
    @AgeMax = 30, 
    @Nombre_Joueur_Min = 4, 
    @Nombre_Joueur_Max = 6, 
    @Duree_Minute = 90, 
    @Date_Creation = '2023-01-01', 
    @utilisateur_id = @utilisateur3;







