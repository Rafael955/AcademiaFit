using AcademiaFit.Domain.Models.Aggregates.SerieAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Interfaces.IRepository
{
    public interface ISerieRepository : IBaseRepository<Serie>
    {
        void RemoverItemDaSerie(ItemSerie itemSerie);
        IEnumerable<Serie> ListarSeriesPorNomeAluno(string busca);
        IEnumerable<Serie> ListarSeriesPorNomeProfessor(string busca);
    }
}
