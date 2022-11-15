using Microsoft.AspNetCore.Mvc;
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
    }
}
