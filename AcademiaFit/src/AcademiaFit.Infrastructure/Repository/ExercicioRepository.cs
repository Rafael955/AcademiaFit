using AcademiaFit.Domain.Interfaces.IRepository;
using AcademiaFit.Domain.Models.Aggregates.SerieAggregate;
using AcademiaFit.Infrastructure.Data.Context;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademiaFit.Infrastructure.Data.Repository
{
    public class ExercicioRepository : BaseRepository<Exercicio>, IExercicioRepository
    {
        private ApplicationDbContext _context;

        public ExercicioRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<SelectListItem> ObterListaExerciciosForDropDown()
        {
            var selectItemList = _context.Exercicios.Select(x => new SelectListItem()
            {
                Text = x.Nome,
                Value = x.Id.ToString()
            });

            return selectItemList;
        }
    }
}
