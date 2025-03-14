using ASP_MVC.Handlers;
using ASP_MVC.Models.Auth;
using BLL.Entities;
using Common;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC.Controllers
{
    public class AuthController : Controller
    {
        private IUtilisateurRepository<Utilisateur> _utilisateurService;
        private SessionManager _sessionManager;

        public AuthController(IUtilisateurRepository<Utilisateur> utilisateurService, SessionManager sessionManager)
        {
            _utilisateurService = utilisateurService;
            _sessionManager = sessionManager;
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
                ConnectedUser utilisateur = new ConnectedUser()
                {
                    Utilisateur_Id = id,
                    Email = form.Email,
                    ConnecteA = DateTime.Now
                };
                _sessionManager.Login(utilisateur);
                return RedirectToAction("Details", "Utilisateur", new { id = id });
            }
            catch (Exception)
            {

                return View();
            }
        }
        public IActionResult Logout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logout(IFormCollection form)
        {
            try
            {
                _sessionManager.Logout();
                return RedirectToAction(nameof(Login));
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}