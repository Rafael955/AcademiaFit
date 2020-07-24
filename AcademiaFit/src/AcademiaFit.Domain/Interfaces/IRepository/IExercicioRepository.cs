using AcademiaFit.Domain.Models.Aggregates.SerieAggregate;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Interfaces.IRepository
{
    public interface IExercicioRepository : IBaseRepository<Exercicio>
    {
        IEnumerable<SelectListItem> ObterListaExerciciosForDropDown();
    }
}
