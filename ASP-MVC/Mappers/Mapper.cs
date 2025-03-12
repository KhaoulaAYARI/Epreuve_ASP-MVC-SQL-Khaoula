using ASP_MVC.Models.Utilisateur;
using BLL.Entities;

namespace ASP_MVC.Mappers
{
    internal static class Mapper
    {
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
    }
}
