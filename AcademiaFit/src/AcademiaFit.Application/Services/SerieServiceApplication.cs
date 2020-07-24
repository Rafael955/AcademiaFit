using AcademiaFit.Application.Interfaces;
using AcademiaFit.Application.ViewModels;
using AcademiaFit.Domain.Interfaces.IService;
using AcademiaFit.Domain.Models.Aggregates.SerieAggregate;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Application.Services
{
    public class SerieServiceApplication : BaseServiceApplication<Serie>, ISerieServiceApplication
    {
        private readonly ISerieServiceDomain _serieServiceDomain;
        private readonly IMapper _mapper;

        public SerieServiceApplication(ISerieServiceDomain serieServiceDomain, IMapper mapper) : base(serieServiceDomain)
        {
            _serieServiceDomain = serieServiceDomain;
            _mapper = mapper;
        }

        public void AdicionarItemNaSerie(ItemSerieViewModel itemSerie)
        {
            _serieServiceDomain.AdicionarItemNaSerie(itemSerie.ItemSerie);
        }

        public void AdicionarSerie(SerieViewModel serie)
        {
            _serieServiceDomain.Adicionar(_mapper.Map<Serie>(serie));
        }

        public void AtualizarSerie(SerieViewModel serie)
        {
            throw new NotImplementedException();
        }

        public void ExcluirSerie(SerieViewModel serie)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SerieViewModel> ListarSeries()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SerieViewModel> ListarSeriesPorNomeAluno(string busca)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SerieViewModel> ListarSeriesPorNomeProfessor(string busca)
        {
            throw new NotImplementedException();
        }

        public SerieViewModel ObterSeriePorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void RemoverItemDaSerie(ItemSerieViewModel itemSerie)
        {
            throw new NotImplementedException();
        }
    }
}
