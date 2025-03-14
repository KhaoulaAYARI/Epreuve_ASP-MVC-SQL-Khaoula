using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface ITagRepository<TTag>
    {
        IEnumerable<TTag> Get();
        TTag GetById(Guid Tag_id);
        Guid Insert(TTag tag);
        void Update(Guid Tag_id, TTag tag);
        void Delete(Guid Tag_id);
        IEnumerable<TTag> GetFromJeu(Guid Jeu_id);
    }
}
