using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Jeu
    {
        public Jeu(Guid jeu_Id, string nom, string description, int ageMin, int ageMax, int nombre_Joueur_Min, int nombre_Joueur_Max, int? duree_Minute, DateTime date_Creation, Guid? cree_Par)
        {
            Jeu_Id = jeu_Id;
            Nom = nom;
            Description = description;
            AgeMin = ageMin;
            AgeMax = ageMax;
            Nombre_Joueur_Min = nombre_Joueur_Min;
            Nombre_Joueur_Max = nombre_Joueur_Max;
            Duree_Minute = duree_Minute;
            Date_Creation = date_Creation;
            Cree_Par = cree_Par;
        }

        public Guid Jeu_Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public int AgeMin { get; set; }
        public int AgeMax { get; set; }
        public int Nombre_Joueur_Min { get; set; }
        public int Nombre_Joueur_Max { get; set; }
        public int? Duree_Minute { get; set; }
        public DateTime Date_Creation { get; set; }
        public Guid? Cree_Par { get; set; }

    }
}
