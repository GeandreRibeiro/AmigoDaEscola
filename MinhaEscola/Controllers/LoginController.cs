using Microsoft.AspNetCore.Mvc;
using MinhaEscola.Models;
using MinhaEscola.Views.Home;

namespace MinhaEscola.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Entrar(LoginModel login)
        {
            return View();
        }
    }
}
