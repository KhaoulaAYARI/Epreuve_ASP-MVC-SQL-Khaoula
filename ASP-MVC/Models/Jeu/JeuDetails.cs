using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_MVC.Models.Jeu
{
    public class JeuDetails
    {
        [ScaffoldColumn(false)]
        public Guid Jeu_Id { get; set; }


        [DisplayName("Nom de jeu: ")]
        public string Nom { get; set; }

        [DisplayName("Description: ")]
        public string Description { get; set; }

        [DisplayName("Age minimum de joueur : ")]
        public int AgeMin { get; set; }

        [DisplayName("Age maximum de joueur : ")]
        public int AgeMax { get; set; }


        [DisplayName("Nombre de joueur minimum: ")]
        public int Nombre_Joueur_Min { get; set; }


        [DisplayName("Nombre de joueur maximum: ")]
        public int Nombre_Joueur_Max { get; set; }


        [DisplayName("Durée en minutes: ")]
        public int? Duree_Minute { get; set; }


        [DisplayName("Date de creation: ")]
        [DataType(DataType.Date)]
        public DateTime Date_Creation { get; set; }


        [DisplayName("Crée par : ")]

        public Guid? Cree_Par { get; set; }
    }
}
