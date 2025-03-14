using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_MVC.Models.Jeu
{
    public class JeuDelete
    {
        [DisplayName("Nom de jeu: ")]
        public string Nom { get; set; }



        [DisplayName("Description: ")]
        public string Description { get; set; }


        [DisplayName("Creer par: ")]
        public Guid? Cree_Par { get; set; }
    }
}
