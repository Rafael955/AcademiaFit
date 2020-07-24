using AcademiaFit.Domain.Interfaces.IRepository;
using AcademiaFit.Domain.Interfaces.IService;
using AcademiaFit.Domain.Models.Aggregates.SerieAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Services
{
    public class SerieServiceDomain : BaseServiceDomain<Serie>, ISerieServiceDomain
    {
        private readonly ISerieRepository _serieRepository;

        public SerieServiceDomain(ISerieRepository serieRepository) : base(serieRepository)
        {
            _serieRepository = serieRepository;
        }

        public void AdicionarItemNaSerie(ItemSerie itemSerie)
        {
            _serieRepository.AdicionarItemNaSerie(itemSerie);
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
            throw new NotImplementedException();
        }
    }
}
