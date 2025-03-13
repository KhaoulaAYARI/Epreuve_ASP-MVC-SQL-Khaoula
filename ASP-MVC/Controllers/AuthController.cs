using ASP_MVC.Models.Auth;
using BLL.Entities;
using Common;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC.Controllers
{
    public class AuthController : Controller
    {
        private IUtilisateurRepository<Utilisateur> _utilisateurService;

        public AuthController(IUtilisateurRepository<Utilisateur> utilisateurService)
        {
            _utilisateurService = utilisateurService;
        }
        public IActionResult Index()
        {
            return RedirectToAction(nameof(Login));
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(AuthLoginForm form)
        {
            try
            {
                if (!ModelState.IsValid) throw new ArgumentException(nameof(form));
                Guid id = _utilisateurService.CheckPassword(form.Email, form.password);
                return RedirectToAction("Details", "Utilisateur", new { id = id });
            }
            catch (Exception)
            {

                return View();
            }
        }
    }
}
