using System;
using System.Collections.Generic;
using AcademiaFit.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaFit.UI.Controllers
{
    public class AlunosController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listagem()
        {
            IEnumerable<AlunoViewModel> listaDeAlunos = new List<AlunoViewModel>();
            return View(listaDeAlunos);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(AlunoViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            return RedirectToAction(nameof(Listagem));
        }
    }
}