using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IJeuRepository<TJeu>
    {
        IEnumerable<TJeu> Get();
        TJeu GetById(Guid Jeu_id);
        Guid Insert(TJeu jeu);
        void Update(Guid Jeu_id, TJeu jeu);
         void Delete(Guid Jeu_id);
        IEnumerable<TJeu> GetFromUser(Guid utilisateur_id);
    }
}
