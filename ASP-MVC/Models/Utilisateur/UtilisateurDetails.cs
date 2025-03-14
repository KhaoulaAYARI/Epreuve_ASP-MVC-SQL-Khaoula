using ASP_MVC.Models.Jeu;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_MVC.Models.Utilisateur
{
    public class UtilisateurDetails
    {
        
        [ScaffoldColumn(false)]
        public Guid Utilisateur_Id { get; set; }
        [DisplayName("Email: ")]
        [EmailAddress]
        public string Email { get; set; }
        [DisplayName("Pseudo: ")]
        public string Pseudo { get; set; }
        [DisplayName("Date d'inscription: ")]
        [DataType(DataType.Date)]
        public DateOnly Date_Creation { get; set; }
        [DisplayName("Votre collection de jeux:")]
        public IEnumerable<JeuListItem> Jeux{ get; set; }
    }
}
