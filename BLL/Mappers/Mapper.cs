using BLL.Entities;
using D=DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    internal static class Mapper
    {
        public static Utilisateur ToBLL(this D.Utilisateur utilisateur)
        {
            if (utilisateur is null) throw new ArgumentNullException(nameof(utilisateur));
            return new Utilisateur(
                utilisateur.Utilisateur_Id,
                utilisateur.Email,
                utilisateur.Password,
                utilisateur.Pseudo,
                utilisateur.Date_Creation,
                utilisateur.Date_Desactivation
                );
        }

        public static D.Utilisateur ToDAL(this Utilisateur utilisateur)
        {
            if (utilisateur is null) throw new ArgumentNullException(nameof(utilisateur));
            return new D.Utilisateur()
            {
                Utilisateur_Id = utilisateur.Utilisateur_Id,
                Email = utilisateur.Email,
                Password = utilisateur.Password,
                Pseudo = utilisateur.Pseudo,
                Date_Creation = utilisateur.Date_Creation,
                Date_Desactivation = (utilisateur.estDesactive)? new DateTime(): null
            };

        }

        public static Jeu ToBLL(this D.Jeu jeu)
        {
            if (jeu is null) throw new ArgumentNullException(nameof(jeu));
            return new Jeu(
                jeu.Jeu_Id,
               jeu.Nom,
               jeu.Description,
               jeu.AgeMin, 
               jeu.AgeMax,
               jeu.Nombre_Joueur_Min,
               jeu.Nombre_Joueur_Max,
               jeu.Duree_Minute,
               jeu.Date_Creation,
               jeu.Cree_Par
                );
        }
        public static D.Jeu ToDAL(this Jeu jeu)
        {
            if (jeu is null) throw new ArgumentNullException(nameof(jeu));
            return new D.Jeu()
            {
                Jeu_Id = jeu.Jeu_Id,
                Nom = jeu.Nom,
                Description = jeu.Description,
                AgeMin = jeu.AgeMin,
                AgeMax = jeu.AgeMax,
                Nombre_Joueur_Min = jeu.Nombre_Joueur_Min,
                Nombre_Joueur_Max = jeu.Nombre_Joueur_Max,
                Duree_Minute= jeu.Duree_Minute,
                Date_Creation = jeu.Date_Creation,
                Cree_Par = jeu.Cree_Par
                //(utilisateur.estDesactive)? new DateTime(): null
            };

        }

    }
}
