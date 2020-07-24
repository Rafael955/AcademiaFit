using AcademiaFit.Domain.Models.Aggregates.SerieAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Interfaces.IService
{
    public interface ISerieServiceDomain : IBaseServiceDomain<Serie>
    {
        void AdicionarItemNaSerie(ItemSerie itemSerie);
        void RemoverItemDaSerie(ItemSerie itemSerie);
        IEnumerable<Serie> ListarSeriesPorNomeAluno(string busca);
        IEnumerable<Serie> ListarSeriesPorNomeProfessor(string busca);
    }
}
