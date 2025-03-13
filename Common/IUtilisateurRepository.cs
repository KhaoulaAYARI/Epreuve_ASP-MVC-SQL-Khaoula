using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IUtilisateurRepository<TUtilisateur>
    {
        IEnumerable<TUtilisateur> Get();
        TUtilisateur GetById(Guid Utilisateur_id);
        Guid Insert(TUtilisateur utilisateur);
        void Update(Guid Utilisateur_id, TUtilisateur utilisateur);
        Guid CheckPassword(string email, string password);
        public void Delete(Guid Utilisateur_id);
    }
}
