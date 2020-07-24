using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AcademiaFit.Application.Interfaces;
using AcademiaFit.Application.ViewModels;
using AcademiaFit.Application.ViewModels.Binders;
using AcademiaFit.Domain.Interfaces.IRepository;
using AcademiaFit.Domain.Models.Aggregates.SerieAggregate;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AcademiaFit.UI.Controllers
{
    public class ProfessoresController : Controller
    {
        private readonly IProfessorServiceApplication _professorServiceApp;
        private readonly IAlunoServiceApplication _alunoServiceApp;
        private readonly ISerieServiceApplication _serieServiceApp;
        private readonly IExercicioRepository _exercicioRepo;

        public ProfessoresController(IProfessorServiceApplication professorServiceApp, IAlunoServiceApplication alunoServiceApp, ISerieServiceApplication serieServiceApp, IExercicioRepository exercicioRepo)
        {
            _professorServiceApp = professorServiceApp;
            _alunoServiceApp = alunoServiceApp;
            _serieServiceApp = serieServiceApp;
            _exercicioRepo = exercicioRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listagem()
        {
            var listaDeProfessores = _professorServiceApp.ListarProfessores();
            return View(listaDeProfessores);
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
            return View(LoadDropDownSerie());
        }

        [HttpPost]
        public IActionResult CriarSerie(string ProfessorResponsavelId, string AlunoId, string ItensSerie)
        {
           var viewModel = FillSerieViewModel(ProfessorResponsavelId, AlunoId, ItensSerie);

            if (!ModelState.IsValid)
            {
                return View(LoadDropDownSerie());
            }

            try
            {
                _serieServiceApp.AdicionarSerie(viewModel);
            }
            catch
            {
                TempData["Created"] = false;
                return View();
            }

            TempData["Created"] = true;
            return View();
        }

        public IActionResult AdicionarItemSerie()
        {
            ViewBag.Title = "";
            return View(LoadDropDownSerie());
        }

        [HttpPost]
        public IActionResult AdicionarItemSerie(ItemSerieViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(LoadDropDownSerie());
            }

            try
            {
                _serieServiceApp.AdicionarItemNaSerie(viewModel);
                TempData["Created"] = true;
            }
            catch (Exception)
            {
                throw new Exception();
            }

            return View(LoadDropDownSerie());
        }

        private SerieViewModel LoadDropDownSerie()
        {
            return new SerieViewModel()
            {
                Serie = new Serie(),
                ItemSerie = new ItemSerie(),
                ListaAlunos = _alunoServiceApp.ObterListaAlunosForDropDown(),
                ListaProfessores = _professorServiceApp.ObterListaProfessoresForDropDown(),
                ListaExercicios = _exercicioRepo.ObterListaExerciciosForDropDown()
            };
        }

        private SerieViewModel FillSerieViewModel(string profId, string aluId, string itensSerie)
        {
            SerieViewModel serieViewModel = new SerieViewModel
            {
                AlunoId = Guid.Parse(aluId),
                ProfessorResponsavelId = Guid.Parse(profId),
                ItensDaSerie = new List<ItemSerie>()
            };

            var itensDaSerie = JsonConvert.DeserializeObject<List<dynamic>>(itensSerie);

            foreach (var item in itensDaSerie)
            {
                serieViewModel.ItensDaSerie.Add(new ItemSerie
                {
                    ExercicioId = item["exercicioId"],
                    NumeroSeries = Convert.ToInt32(item["numSeries"]),
                    NumeroRepeticoes = Convert.ToInt32(item["numReps"]),
                    Observacoes = item["observacao"].ToString()
                });
            }

            return serieViewModel;
        }
    }
}