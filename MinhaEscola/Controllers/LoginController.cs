using Microsoft.AspNetCore.Mvc;
using MinhaEscola.DateBase.Repositorios;
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


        [HttpPost]
        public IActionResult Entrar(LoginModel login)
        {

            if (!new RepositorioLogin().CheckCredentials(login.Email, login.Senha))
            {
                TempData["AlertMessage"] = "Email não cadastrado na base de dados.";
                return RedirectToAction("Index");
            }
            
            //Manda gravar os dados
            return RedirectToAction("Index");
        }
    }
}
