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
            try
            {
                UtilisateurDetails model = _utilisateurService.GetById(id).ToDetails();
                return View(model);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home");
            }
        }
        

        // GET: UtilisateurController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UtilisateurController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UtilisateurCreateForm form)
        {
            try
            {
                
                if (!ModelState.IsValid) throw new ArgumentException();
                Guid id = _utilisateurService.Insert(form.ToBLL());
                return RedirectToAction(nameof(Details), new { id = id });///////
            }
            catch
            {
                return View();
            }
        }

        // GET: UtilisateurController/Edit/5
        public ActionResult Edit(Guid id)
        {
            try
            {
                UtilisateurEditForm model = _utilisateurService.GetById(id).ToEditForm();
                return View(model);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home");
            }

        }

        // POST: UtilisateurController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, UtilisateurEditForm form)
        {
            try
            {
                if (!ModelState.IsValid) throw new ArgumentException(nameof(form));
                _utilisateurService.Update(id, form.ToBLL());
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
