using AcademiaFit.Application.ViewModels;
using AcademiaFit.Domain.Models.Aggregates.SerieAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Application.Interfaces
{
    public interface ISerieServiceApplication : IBaseServiceApplication<Serie>
    {
        void AdicionarSerie(SerieViewModel serie);
        SerieViewModel ObterSeriePorId(Guid id);
        IEnumerable<SerieViewModel> ListarSeries();
        void AtualizarSerie(SerieViewModel serie);
        void ExcluirSerie(SerieViewModel serie);

        void AdicionarItemNaSerie(ItemSerieViewModel itemSerie);
        void RemoverItemDaSerie(ItemSerieViewModel itemSerie);
        IEnumerable<SerieViewModel> ListarSeriesPorNomeAluno(string busca);
        IEnumerable<SerieViewModel> ListarSeriesPorNomeProfessor(string busca);
    }
}
