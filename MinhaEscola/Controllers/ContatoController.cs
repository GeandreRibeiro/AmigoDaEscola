using Microsoft.AspNetCore.Mvc;
using MinhaEscola.DateBase.Repositorios;
using MinhaEscola.Models;
using System.Diagnostics;

namespace MinhaEscola.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult IncluirContatoC(ContatoModel contato)
        {
            if(new RepositorioContato().IncluirContato(contato))
            {
                TempData["AlertMessage"] = "Recebemos seu pedido de contato. Em breve entraremos em contato.";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["AlertMessage"] = "Ocorreu algum erro ao receber seus dados. Tente novamente mais tarde.";
                return RedirectToAction("Index");
            }

        }
    }
}
