using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcademiaFit.Domain.Interfaces.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaFit.UI.Controllers
{
    public class SeriesController : Controller
    {
        private readonly IAlunoRepository _alunoRepo;
        
        public SeriesController(IAlunoRepository alunoRepo)
        {
            _alunoRepo = alunoRepo;
        }

        public IActionResult Listagem()
        {
            return View();
        }
    }
}