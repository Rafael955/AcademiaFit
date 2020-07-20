using AcademiaFit.Domain.Models.Aggregates.SerieAggregate;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Application.ViewModels
{
    public class SerieViewModel
    {
        public Serie Serie { get; set; }
        public IEnumerable<SelectListItem> ListaProfessores { get; set; }
        public IEnumerable<SelectListItem> ListaAlunos { get; set; }
    }
}
