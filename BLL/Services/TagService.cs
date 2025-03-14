using BLL.Entities;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class TagService : ITagRepository<Tag>
    {
        public void Delete(Guid Tag_id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> Get()
        {
            throw new NotImplementedException();
        }

        public Tag GetById(Guid Tag_id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> GetFromJeu(Guid Jeu_id)
        {
            throw new NotImplementedException();
        }

        public Guid Insert(Tag tag)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid Tag_id, Tag tag)
        {
            throw new NotImplementedException();
        }
    }
}
