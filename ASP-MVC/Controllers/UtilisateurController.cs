using ASP_MVC.Mappers;
using ASP_MVC.Models.Utilisateur;
using BLL.Entities;
using BLL.Services;
using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC.Controllers
{
    public class UtilisateurController : Controller
    {
        private IUtilisateurRepository<Utilisateur> _utilisateurService;

        public UtilisateurController(IUtilisateurRepository<Utilisateur> utilisateurService)
        {
            _utilisateurService= utilisateurService;
        }
        // GET: UtilisateurController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UtilisateurController/Details/5
        public ActionResult Details(Guid id)
        {
            UtilisateurDetails model = _utilisateurService.GetById(id).ToDetails();
            return View();
        }

        // GET: UtilisateurController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UtilisateurController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UtilisateurController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UtilisateurController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UtilisateurController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UtilisateurController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
