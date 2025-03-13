using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_MVC.Models.Utilisateur
{
    public class UtilisateurCreateForm
    {
        [ScaffoldColumn(false)]
        public Guid Utilisateur_Id { get; set; }


        [DisplayName("Email: ")]
        [Required(ErrorMessage ="Le champ (Email) est obligatoire")]
        [EmailAddress]
        public string Email { get; set; }


        [DisplayName("Pseudo: ")]
        [Required(ErrorMessage = "Le champ (Pseudo) est obligatoire")]
        [MaxLength(64, ErrorMessage = "Le champ (Pseudo) doit contenier au maximum 64 caracteres")]
        [MinLength(2, ErrorMessage = "Le champ (Pseudo) doit contenier au minimum 2 caracteres")]
        public string Pseudo { get; set; }


        [DisplayName("Mot de passe: ")]
        [Required(ErrorMessage = "Le champ (Mot de passe) est obligatoire")]
        [MaxLength(32, ErrorMessage = "Le champ (Mot de passe) doit contenier au maximum 32 caracteres")]
        [MinLength(8, ErrorMessage = "Le champ (Mot de passe) doit contenier au minimum 8 caracteres")]
        [RegularExpression(@"^.*(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\-_+=\.()\[\]$µ£\\/*§?{}]).*", ErrorMessage = "Le champ 'Mot de passe' doit contenir au minimum une minuscule, une majuscule, un chiffre et un symbole.")]
        [DataType(DataType.Password)]
        public string password { get; set; }


        [DisplayName("Veuillez confirmer le mot de passe: ")]
        [Required(ErrorMessage = "La confirmation de mot de passe est obligatoire")]
        [Compare(nameof(password),ErrorMessage= "La confirmation ne correspond pas qu champ (mot de passe)")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        

    }
}
