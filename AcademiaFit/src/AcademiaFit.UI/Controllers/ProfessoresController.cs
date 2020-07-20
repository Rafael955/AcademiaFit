using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcademiaFit.Application.Interfaces;
using AcademiaFit.Application.ViewModels;
using AcademiaFit.Domain.Interfaces.IRepository;
using AcademiaFit.Domain.Models.Aggregates.SerieAggregate;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaFit.UI.Controllers
{
    public class ProfessoresController : Controller
    {
        private readonly IProfessorServiceApplication _professorServiceApp;
        private readonly IAlunoServiceApplication _alunoServiceApp;

        public ProfessoresController(IProfessorServiceApplication professorServiceApp, IAlunoServiceApplication alunoServiceApp)
        {
            _professorServiceApp = professorServiceApp;
            _alunoServiceApp = alunoServiceApp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listagem()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(ProfessorViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            try
            {
                _professorServiceApp.AdicionarProfessor(viewModel);
            }
            catch (Exception)
            {
                throw new Exception();
            }

            return RedirectToAction(nameof(Listagem));
        }

        public IActionResult CriarSerie()
        {
            return View(LoadSerieViewModel());
        }

        private SerieViewModel LoadSerieViewModel()
        {
            return new SerieViewModel()
            {
                Serie = new Serie(),
                ListaAlunos = _alunoServiceApp.ObterListaAlunosForDropDown(),
                ListaProfessores = _professorServiceApp.ObterListaProfessoresForDropDown()
            };
        }
    }
}