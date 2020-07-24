using AcademiaFit.Domain.Models.Aggregates.SerieAggregate;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Application.ViewModels
{
    public class SerieViewModel
    {

        public Guid ProfessorResponsavelId { get; set; }
        public Guid AlunoId { get; set; }

        public Serie Serie { get; set; }
        public ItemSerie ItemSerie { get; set; }
        public List<ItemSerie> ItensDaSerie { get; set; }

        public IEnumerable<SelectListItem> ListaProfessores { get; set; }
        public IEnumerable<SelectListItem> ListaAlunos { get; set; }
        public IEnumerable<SelectListItem> ListaExercicios { get; set; }
    }
}
