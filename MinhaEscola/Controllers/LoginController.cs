using Microsoft.AspNetCore.Mvc;
using MinhaEscola.Dominio.Entidades;

using MinhaEscola.Models;
using MinhaEscola.Repositorio;
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

            ELogin log = new ELogin(login.Id, login.Email, login.Senha);

            if (!new LoginRepositorio(log).ChekLongin())
            {
                TempData["AlertMessage"] = "Email ou Senha não cadastrado na base de dados.";
                return RedirectToAction("Index");
            }
            
            //Manda gravar os dados
            return RedirectToAction("Index");
        }
    }
}
