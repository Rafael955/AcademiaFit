using AcademiaFit.Application.Interfaces;
using AcademiaFit.Application.ViewModels;
using AcademiaFit.Domain.Interfaces.IService;
using AcademiaFit.Domain.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Application.Services
{
    public class ProfessorServiceApplication : BaseServiceApplication<Professor>, IProfessorServiceApplication
    {
        private readonly IProfessorServiceDomain _professorServiceDomain;
        private readonly IMapper _mapper;

        public ProfessorServiceApplication(IProfessorServiceDomain professorServiceDomain, IMapper mapper) : base(professorServiceDomain)
        {
            _professorServiceDomain = professorServiceDomain;
            _mapper = mapper;
        }

        public void AdicionarProfessor(ProfessorViewModel professor)
        {
            _professorServiceDomain.Adicionar(_mapper.Map<Professor>(professor));
        }

        public void AtualizarProfessor(ProfessorViewModel professor)
        {
            throw new NotImplementedException();
        }

        public void ExcluirProfessor(ProfessorViewModel professor)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProfessorViewModel> ListarAvaliacoesFisicasDoProfessor()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProfessorViewModel> ListarProfessores()
        {
            return _mapper.Map<List<ProfessorViewModel>>(_professorServiceDomain.Listar());
        }

        public IEnumerable<ProfessorViewModel> ListarProfessoresAtivos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProfessorViewModel> ListarSeriesDoProfessor()
        {
            throw new NotImplementedException();
        }

        public ProfessorViewModel ObterProfessorPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public ProfessorViewModel ObterProfessorPorNome(string busca)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SelectListItem> ObterListaProfessoresForDropDown()
        {
            return _professorServiceDomain.ObterListaProfessoresForDropDown();
        }
    }
}
