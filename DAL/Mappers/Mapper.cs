using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    internal static class Mapper
    {
        public static Utilisateur ToUtilisateur(this IDataRecord record)
        {
            if (record is null) throw new ArgumentNullException(nameof(record));
            return new Utilisateur()
            {
                Utilisateur_Id = (Guid)record[nameof(Utilisateur.Utilisateur_Id)],
                Email = (string)record[nameof(Utilisateur.Email)],
                Password = "********",
                Pseudo = (string)record[nameof(Utilisateur.Pseudo)],
                Date_Creation = (DateTime)record[nameof(Utilisateur.Date_Creation)],
                Date_Desactivation = (record[nameof(Utilisateur.Date_Desactivation)] is DBNull) ? null : (DateTime?)record[nameof(Utilisateur.Date_Desactivation)]
            };
        }
        public static Jeu ToJeu(this IDataRecord record)
        {
            if (record is null) throw new ArgumentNullException(nameof(record));
            return new Jeu()
            {
                Jeu_Id= (Guid)record[nameof(Jeu.Jeu_Id)],
                Nom=(string)record[nameof(Jeu.Nom)],
                Description = (string)record[nameof(Jeu.Description)],
                AgeMin = (int)record[nameof(Jeu.AgeMin)],
                AgeMax =(int)record[nameof(Jeu.AgeMax)],
                Nombre_Joueur_Min= (int)record[nameof(Jeu.Nombre_Joueur_Min)],
                Nombre_Joueur_Max = (int)record[nameof(Jeu.Nombre_Joueur_Max)],
                Duree_Minute= (record[nameof(Jeu.Duree_Minute)] is DBNull) ? null : (int?)record[nameof(Jeu.Duree_Minute)],
                Date_Creation=(DateTime)record[nameof(Jeu.Date_Creation)],
                Cree_Par= (record[nameof(Jeu.Cree_Par)] is DBNull) ? null : (Guid?)record[nameof(Jeu.Cree_Par)]
            };

        }
        public static Tag ToTag(this IDataRecord record)
        {
            if (record is null) throw new ArgumentNullException(nameof(record));
            return new Tag()
            {
                Tag_Id = (Guid)record[nameof(Tag.Tag_Id)],
                Nom = (string)record[nameof(Tag.Nom)],
                Description = (record[nameof(Tag.Description)] is DBNull) ? null : (string?)record[nameof(Tag.Description)]
            };

        }
    }
}
