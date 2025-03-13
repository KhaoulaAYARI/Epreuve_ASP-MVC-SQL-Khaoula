using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_MVC.Models.Utilisateur
{
    public class UtilisateurDelete
    {
        [DisplayName("Email")]
        [EmailAddress]
        public string Email { get; set; }

        [DisplayName("Pseudo")]
        public string Pseudo { get; set; }
    }
}
