using Microsoft.AspNetCore.Mvc;

namespace Projeto_MVC.Controllers;

public class AlunoController : Controller
{
    // Passo 3: Método Index definindo as ViewBags
    public IActionResult Index()
    {
        ViewBag.Nome = "Ricardo De Santana"; // Pode colocar seu nome aqui!
        ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
        ViewBag.Semestre = "1º Semestre";

        return View();
    }

    // Passo 6: Crie um método Detalhes(int id) que recebe o ID do aluno
    public IActionResult Detalhes(int id)
    {
        ViewBag.Id = id;
        ViewBag.Nome = "Aluno Exemplo ID " + id;
       
        return View();
    }
} 