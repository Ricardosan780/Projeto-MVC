using Microsoft.AspNetCore.Mvc;

namespace Projeto_MVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Salvar(string nome, string email, int idade)
        {
            ViewBag.Mensagem = "Aluno cadastrado com sucesso!";
            return View("Index");
        } // <- Faltava fechar essa chave do método Salvar
    }
} // <- Faltava fechar essa chave do namespace 