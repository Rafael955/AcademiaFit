using AcademiaFit.Domain.Interfaces.IRepository;
using AcademiaFit.Domain.Models.Aggregates.SerieAggregate;
using AcademiaFit.Infrastructure.Data.Context;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademiaFit.Infrastructure.Data.Repository
{
    public class SerieRepository : BaseRepository<Serie>, ISerieRepository
    {
        private ApplicationDbContext _context;

        public SerieRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void AdicionarItemNaSerie(ItemSerie itemSerie)
        {
            _context.ItensSeries.Add(itemSerie);
            _context.SaveChanges();
        }

        public override IEnumerable<Serie> Listar()
        {
            return _context.Series.Include(x => x.ItemsDaSerie).ToList();
        }

        public IEnumerable<Serie> ListarSeriesPorNomeAluno(string busca)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Serie> ListarSeriesPorNomeProfessor(string busca)
        {
            throw new NotImplementedException();
        }

        public void RemoverItemDaSerie(ItemSerie itemSerie)
        {
            _context.ItensSeries.Remove(itemSerie);
            _context.SaveChanges();
        }
    }
}
