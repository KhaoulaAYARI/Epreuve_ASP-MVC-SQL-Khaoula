using BLL.Entities;
using BLL.Mappers;
using D = DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UtilisateurService
    {
        private D.UtilisateurService _service;
        public UtilisateurService()
        {
            _service=new D.UtilisateurService();
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

    }
}
