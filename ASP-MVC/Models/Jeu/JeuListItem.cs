using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_MVC.Models.Jeu
{
    public class JeuListItem
    {
        [ScaffoldColumn(false)]
        public Guid Jeu_Id { get; set; }
        [DisplayName("Nom de jeu: ")]
        public string Nom { get; set; }

        [DisplayName("Description: ")]
        public string Description { get; set; }
    }
}
