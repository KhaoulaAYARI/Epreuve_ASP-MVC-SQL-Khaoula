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
    }
}
