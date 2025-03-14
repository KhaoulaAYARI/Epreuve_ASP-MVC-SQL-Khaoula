using BLL.Entities;
using BLL.Mappers;
using Common;
//using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class JeuService : IJeuRepository<Jeu>
    {
        private IJeuRepository<DAL.Entities.Jeu> _jeuService;
        private IUtilisateurRepository<DAL.Entities.Utilisateur> _utilisateurService;
        public JeuService(IJeuRepository<DAL.Entities.Jeu> jeuService, IUtilisateurRepository<DAL.Entities.Utilisateur> utilisateurService)
        {
            _jeuService=jeuService;
            _utilisateurService=utilisateurService;
        }
        public void Delete(Guid Jeu_id)
        {
            _jeuService.Delete(Jeu_id);
        }

        public IEnumerable<Jeu> Get()
        {
            IEnumerable<Jeu> jeux= _jeuService.Get().Select(dal => dal.ToBLL());
            foreach(Jeu jeu in jeux)
            {
                if (jeu.Cree_Par is not null)
                {
                    jeu.Createur = _utilisateurService.GetById((Guid)jeu.Cree_Par).ToBLL();
                }

            }
            return jeux;
        }

        public Jeu GetById(Guid Jeu_id)
        {
            Jeu jeu= _jeuService.GetById(Jeu_id).ToBLL();
            if (jeu.Cree_Par is not null)
            {
                jeu.Createur = _utilisateurService.GetById((Guid)jeu.Cree_Par).ToBLL();
            }
            return jeu;
        }

        public IEnumerable<Jeu> GetFromUser(Guid utilisateur_id)
        {
            return _jeuService.GetFromUser(utilisateur_id).Select(dal => dal.ToBLL());
        }

        public Guid Insert(Jeu jeu)
        {
            return _jeuService.Insert(jeu.ToDAL());
        }

        public void Update(Guid Jeu_id, Jeu jeu)
        {
            _jeuService.Update(Jeu_id, jeu.ToDAL());
        }
    }
}
