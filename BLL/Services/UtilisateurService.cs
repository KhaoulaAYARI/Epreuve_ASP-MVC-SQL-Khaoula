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
        private IUtilisateurRepository<D.Utilisateur> _utilisateurService;
        private IJeuRepository<D.Jeu> _jeuService;

        public UtilisateurService(IUtilisateurRepository<D.Utilisateur> utilisateurService, IJeuRepository<D.Jeu> jeuService)
        {
            _utilisateurService= utilisateurService;
            _jeuService= jeuService;
        }
        public IEnumerable<Utilisateur> Get()
        {
            return _utilisateurService.Get().Select(dal=>dal.ToBLL());
        }
        public Utilisateur GetById(Guid utilisateur_Id) 
        {
                Utilisateur utilisateur= _utilisateurService.GetById(utilisateur_Id).ToBLL();
            utilisateur.JEUX=_jeuService.GetFromUser(utilisateur_Id).Select(dal=>dal.ToBLL());
            return utilisateur;
        }
        public Guid Insert(Utilisateur utilisateur)
        {
            return _utilisateurService.Insert(utilisateur.ToDAL());
        }
        public void Update (Guid utilisateur_id, Utilisateur utilisateur)
        {
            _utilisateurService.Update(utilisateur_id, utilisateur.ToDAL());
        }
        public Guid CheckPassword(string email, string password)
        {
            return _utilisateurService.CheckPassword(email, password);
        }

        public void Delete(Guid Utilisateur_id)
        {
            _utilisateurService.Delete(Utilisateur_id);

        }
    }
}
