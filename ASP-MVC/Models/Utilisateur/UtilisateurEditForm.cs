using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_MVC.Models.Utilisateur
{
    public class UtilisateurEditForm
    {
        [ScaffoldColumn(false)]
        public Guid Utilisateur_Id { get; set; }


        [DisplayName("Pseudo: ")]
        [Required(ErrorMessage = "Le champ (Pseudo) est obligatoire")]
        [MaxLength(64, ErrorMessage = "Le champ (Pseudo) doit contenier au maximum 64 caracteres")]
        [MinLength(2, ErrorMessage = "Le champ (Pseudo) doit contenier au minimum 2 caracteres")]
        public string Pseudo { get; set; }
    }
}
