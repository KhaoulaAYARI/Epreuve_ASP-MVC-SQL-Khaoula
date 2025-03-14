using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_MVC.Models.Utilisateur
{
    public class UtilisateurListItem
    {
        [ScaffoldColumn(false)]
        public Guid Utilisateur_Id { get; set; }
        
        [DisplayName("Pseudo: ")]
        public string Pseudo { get; set; }
    }
}
