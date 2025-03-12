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
    }
}
