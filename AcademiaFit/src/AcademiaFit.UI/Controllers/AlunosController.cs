using System;
using System.Collections.Generic;
using AcademiaFit.Application.Interfaces;
using AcademiaFit.Application.ViewModels;
using AcademiaFit.Domain.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaFit.UI.Controllers
{
    public class AlunosController : Controller
    {
        private readonly IAlunoServiceApplication _alunoServiceApp;

        public AlunosController(IAlunoServiceApplication alunoServiceApp)
        {
            _alunoServiceApp = alunoServiceApp;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listagem()
        {
            var listaDeAlunos = _alunoServiceApp.ListarAlunos();
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

            try
            {
                _alunoServiceApp.AdicionarAluno(viewModel);
            }
            catch (Exception)
            {
                throw new Exception();
            }

            return RedirectToAction(nameof(Listagem));
        }
    }
}