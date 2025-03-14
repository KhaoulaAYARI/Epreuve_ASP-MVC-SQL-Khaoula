using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Utilisateur
    {
        public Guid Utilisateur_Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Pseudo { get; set; }
        public DateTime Date_Creation { get; set; }
        private DateTime? _date_desactivation;
        public bool estDesactive
        {
            get { return _date_desactivation is not null; }
        }
        public IEnumerable<Jeu> JEUX { get; set; }


        public Utilisateur(Guid utilisateur_Id, string email, string password, string pseudo, DateTime date_Creation, DateTime? date_desactivation)
        {
            Utilisateur_Id = utilisateur_Id;
            Email = email;
            Password = password;
            Pseudo = pseudo;
            Date_Creation = date_Creation;
            _date_desactivation = date_desactivation;
        }
        public Utilisateur( string email, string password, string pseudo)
        {
            Email = email;
            Password = password;
            Pseudo = pseudo;
        }
        public Utilisateur(string pseudo)
        {
           
            Pseudo = pseudo;
        }
    }
}
