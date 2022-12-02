using Microsoft.AspNetCore.Mvc;
using MinhaEscola.Dominio.Entidades;
using MinhaEscola.Dominio.Interfaces;
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
        public IActionResult Entrar(ELogin login)
        {

            if (!new LoginRepositorio(login).ChekLongin())
            {
                TempData["AlertMessage"] = "Email não cadastrado na base de dados.";
                return RedirectToAction("Index");
            }
            
            //Manda gravar os dados
            return RedirectToAction("Index");
        }
    }
}
