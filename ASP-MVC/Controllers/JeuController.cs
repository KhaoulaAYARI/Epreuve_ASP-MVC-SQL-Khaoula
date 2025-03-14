using ASP_MVC.Mappers;
using ASP_MVC.Models.Jeu;
using BLL.Entities;
using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC.Controllers
{
    public class JeuController : Controller
    {
        private IJeuRepository<Jeu> _jeuRepository;
        public JeuController(IJeuRepository<Jeu> jeuRepository)
        {
            _jeuRepository = jeuRepository;
        }

        // GET: jeuController
        public ActionResult Index()
        {
            try
            {
                IEnumerable<JeuListItem> model = _jeuRepository.Get().Select(bll => bll.ToListeItem());
                return View(model);

            }
            catch (Exception)
            {

                return RedirectToAction("Error","Home");
            }        
        }

        // GET: jeuController/Details/5
        public ActionResult Details(Guid id)
        {
            try
            {
                JeuDetails model=_jeuRepository.GetById(id).ToDetails();
                return View(model);
            }
            catch (Exception)
            {

                return RedirectToAction("Error","Home");
            }
        }

        // GET: jeuController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: jeuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(JeuCreateForm form)
        {
            try
            {
                if (!ModelState.IsValid) throw new ArgumentException(nameof(form));
                Guid id = _jeuRepository.Insert(form.ToBLL());
                return RedirectToAction(nameof(Details), new {id});
            }
            catch
            {
                return View();
            }
        }

        // GET: jeuController/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View();
        }

        // POST: jeuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, IFormCollection collection)
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

        // GET: jeuController/Delete/5
        public ActionResult Delete(Guid id)
        {
            try
            {
                JeuDelete model = _jeuRepository.GetById(id).ToDelete();
                return View(model);
            }
            catch (Exception)
            {

                return RedirectToAction(nameof(Index));
            }
        }

        // POST: jeuController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, JeuDelete form)
        {
            try
            {
                _jeuRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
