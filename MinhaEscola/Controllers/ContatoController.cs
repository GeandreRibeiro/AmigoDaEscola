using Microsoft.AspNetCore.Mvc;
using MinhaEscola.Dominio.Entidades;
using MinhaEscola.Models;
using MinhaEscola.Repositorio;
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
            EContatos cont = new EContatos(
                contato.Id,
                contato.Email, 
                contato.Telefone,
                contato.Nome,
                contato.SobreNome, 
                contato.Cidade, 
                contato.Estado,
                contato.Cep, 
                contato.ReceberInf, 
                contato.Contatado
                );

            if(new ContatoRepositorio(cont).Gravar())
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
