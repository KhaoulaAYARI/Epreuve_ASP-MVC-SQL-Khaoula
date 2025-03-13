using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_MVC.Models.Auth
{
    public class AuthLoginForm
    {
        [DisplayName("Email: ")]
        [Required(ErrorMessage = "Le champ (Email) est obligatoire")]
        [EmailAddress]
        public string Email { get; set; }



        [DisplayName("Mot de passe: ")]
        [Required(ErrorMessage = "Le champ (Mot de passe) est obligatoire")]
        [MaxLength(32, ErrorMessage = "Le champ (Mot de passe) doit contenier au maximum 32 caracteres")]
        [MinLength(8, ErrorMessage = "Le champ (Mot de passe) doit contenier au minimum 8 caracteres")]
        [RegularExpression(@"^.*(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\-_+=\.()\[\]$µ£\\/*§?{}]).*", ErrorMessage = "Le champ 'Mot de passe' doit contenir au minimum une minuscule, une majuscule, un chiffre et un symbole.")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
