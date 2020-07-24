using AcademiaFit.Domain.Models.Aggregates.SerieAggregate;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Application.ViewModels
{
    public class ItemSerieViewModel
    {
        public ItemSerie ItemSerie { get; set; }
        public IEnumerable<SelectListItem> ListaExercicios { get; set; }
    }
}
