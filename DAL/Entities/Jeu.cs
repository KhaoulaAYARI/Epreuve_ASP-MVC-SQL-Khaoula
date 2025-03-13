using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Jeu
    {
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
