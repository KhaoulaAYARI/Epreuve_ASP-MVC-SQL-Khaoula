using BLL.Entities;
using BLL.Mappers;
using D = DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace BLL.Services
{
    public class UtilisateurService:IUtilisateurRepository<Utilisateur>
    {
        private IUtilisateurRepository<D.Utilisateur> _service;
        public UtilisateurService(IUtilisateurRepository<D.Utilisateur> utilisateurService)
        {
            _service= utilisateurService;
        }
        public IEnumerable<Utilisateur> Get()
        {
            return _service.Get().Select(dal=>dal.ToBLL());
        }
        public Utilisateur GetById(Guid utilisateur_Id) 
        {
                return _service.GetById(utilisateur_Id).ToBLL();
        }
        public Guid Insert(Utilisateur utilisateur)
        {
            return _service.Insert(utilisateur.ToDAL());
        }
        public void Update (Guid utilisateur_id, Utilisateur utilisateur)
        {
            _service.Update(utilisateur_id, utilisateur.ToDAL());
        }
        public Guid CheckPassword(string email, string password)
        {
            return _service.CheckPassword(email, password);
        }

        public void Delete(Guid Utilisateur_id)
        {
            _service.Delete(Utilisateur_id);

        }
    }
}
