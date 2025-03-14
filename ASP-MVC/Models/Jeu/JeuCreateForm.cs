using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC.Models.Jeu
{
    public class JeuCreateForm
    {
        [DisplayName("Nom de jeu: ")]
        [Required(ErrorMessage = "Le champ (Nom de jeu) est obligatoire")]
        [MaxLength(64, ErrorMessage = "Le champ (Nom de jeu) doit contenier au maximum 64 caracteres")]
        [MinLength(2, ErrorMessage = "Le champ (Nom de jeu) doit contenier au minimum 2 caracteres")]
        public string Nom { get; set; }



        [DisplayName("Description: ")]
        [Required(ErrorMessage = "Le champ (Description) est obligatoire")]
        [MaxLength(512, ErrorMessage = "Le champ (Description) doit contenier au maximum 512 caracteres")]
        [MinLength(2, ErrorMessage = "Le champ (Description) doit contenier au minimum 2 caracteres")]
        public string Description { get; set; }



        [DisplayName("Age minimum de joueur : ")]
        [Required(ErrorMessage = "Le champ (Age minimum de joueur) est obligatoire")]
        public int AgeMin { get; set; }



        [DisplayName("Age maximum de joueur : ")]
        [Required(ErrorMessage = "Le champ (Age maximum de joueur) est obligatoire")]
        public int AgeMax { get; set; }




        [DisplayName("Nombre de joueur minimum: ")]
        [Required(ErrorMessage = "Le champ (Nombre minimum de joueur) est obligatoire")]
        public int Nombre_Joueur_Min { get; set; }




        [DisplayName("Nombre de joueur maximum: ")]
        [Required(ErrorMessage = "Le champ (Nombre maximum de joueur) est obligatoire")]
        public int Nombre_Joueur_Max { get; set; }




        [DisplayName("Durée en minutes: ")]
        public int? Duree_Minute { get; set; }


        [DisplayName("Date de creation: ")]
        [Required(ErrorMessage = "Le champ (Date de creation) est obligatoire")]
        [DataType(DataType.Date)]
        public DateTime Date_Creation { get; set; }

        [HiddenInput]
         public Guid? Cree_Par { get; set; }

    }
}
