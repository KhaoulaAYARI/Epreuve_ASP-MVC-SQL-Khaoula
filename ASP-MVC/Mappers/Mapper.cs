using ASP_MVC.Models.Jeu;
using ASP_MVC.Models.Utilisateur;
using BLL.Entities;
using Humanizer;

namespace ASP_MVC.Mappers
{
    internal static class Mapper
    {
        //________________Utilisateur_______________//

        public static UtilisateurDetails ToDetails(this Utilisateur utilisateur)
        {
            if (utilisateur is null) throw new ArgumentNullException(nameof(utilisateur));
            return new UtilisateurDetails()
            {
                Utilisateur_Id = utilisateur.Utilisateur_Id,
                Email = utilisateur.Email,
                Pseudo = utilisateur.Pseudo,
                Date_Creation = DateOnly.FromDateTime(utilisateur.Date_Creation)
            };
        }
        public static Utilisateur ToBLL(this UtilisateurCreateForm utilisateur)
        {
            if (utilisateur is null) throw new ArgumentNullException(nameof(utilisateur));
            return new Utilisateur(
                Guid.NewGuid(),
                utilisateur.Email,
                utilisateur.password,
                utilisateur.Pseudo,
                DateTime.Now,
                null
                );
        }
        public static UtilisateurEditForm ToEditForm(this Utilisateur utilisateur)
        {
            if (utilisateur is null) throw new ArgumentNullException(nameof(utilisateur));
            return new UtilisateurEditForm()
            {
                Pseudo = utilisateur.Pseudo,

            };
        }
        public static Utilisateur ToBLL(this UtilisateurEditForm utilisateur)
        {
            if (utilisateur is null) throw new ArgumentNullException(nameof(utilisateur));

            return new Utilisateur(

                Guid.Empty,
                "********",
                "********",
                utilisateur.Pseudo,
                 DateTime.Now,
                null
               );
        }
        public static UtilisateurDelete ToDelete(this Utilisateur utilisateur)
        {
            if (utilisateur is null) throw new ArgumentNullException(nameof(utilisateur));
            return new UtilisateurDelete()
            {
                Email = utilisateur.Email,
                Pseudo = utilisateur.Pseudo
            };




        }
        //________________JEU_______________//

        public static JeuListItem ToListeItem(this Jeu jeu)
        {
            if (jeu is null) throw new ArgumentNullException(nameof(jeu));

            return new JeuListItem()
            {
                Jeu_Id = jeu.Jeu_Id,
                Nom = jeu.Nom,
                Description = jeu.Description
            };

        }
        public static JeuDetails ToDetails(this Jeu jeu)
        {
            if (jeu is null) throw new ArgumentNullException(nameof(jeu));
            return new JeuDetails()
            {
                Jeu_Id = jeu.Jeu_Id,
                Nom = jeu.Nom,
                Description = jeu.Description,
                AgeMin = jeu.AgeMin,
                AgeMax = jeu.AgeMax,
                Nombre_Joueur_Min = jeu.Nombre_Joueur_Min,
                Nombre_Joueur_Max = jeu.Nombre_Joueur_Max,
                Duree_Minute = jeu.Duree_Minute,
                Date_Creation = jeu.Date_Creation,
                Cree_Par = jeu.Cree_Par
            };
        }
        public static Jeu ToBLL(this JeuCreateForm jeu)
        {
            if (jeu is null) throw new ArgumentNullException(nameof(jeu));
            return new Jeu(
                Guid.Empty,
                jeu.Nom,
                jeu.Description,
                jeu.AgeMin,
                jeu.AgeMax,
                jeu.Nombre_Joueur_Min,
                jeu.Nombre_Joueur_Max,
                jeu.Duree_Minute,
                DateTime.Now,
                jeu.Cree_Par
                );
        }

        public static JeuDelete ToDelete(this Jeu jeu)
        {
            if (jeu is null) throw new ArgumentNullException(nameof(jeu));

            return new JeuDelete()
            {
                Nom=jeu.Nom,
                Description=jeu.Description,
                Cree_Par=jeu.Cree_Par

            };
        }

    }
}
