using BLL.Entities;
using BLL.Mappers;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class JeuService : IJeuRepository<Jeu>
    {
        private IJeuRepository<DAL.Entities.Jeu> _service;
        public JeuService(IJeuRepository<DAL.Entities.Jeu> service)
        {
            _service=service;
        }
        public void Delete(Guid Jeu_id)
        {
            _service.Delete(Jeu_id);
        }

        public IEnumerable<Jeu> Get()
        {
            return _service.Get().Select(dal => dal.ToBLL());
        }

        public Jeu GetById(Guid Jeu_id)
        {
            return _service.GetById(Jeu_id).ToBLL();
        }

        public IEnumerable<Jeu> GetFromUser(Guid utilisateur_id)
        {
            return _service.GetFromUser(utilisateur_id).Select(dal => dal.ToBLL());
        }

        public Guid Insert(Jeu jeu)
        {
            return _service.Insert(jeu.ToDAL());
        }

        public void Update(Guid Jeu_id, Jeu jeu)
        {
            _service.Update(Jeu_id, jeu.ToDAL());
        }
    }
}
