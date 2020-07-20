using AcademiaFit.Application.Interfaces;
using AcademiaFit.Application.ViewModels;
using AcademiaFit.Domain.Interfaces.IService;
using AcademiaFit.Domain.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace AcademiaFit.Application.Services
{
    public class AlunoServiceApplication : BaseServiceApplication<Aluno>, IAlunoServiceApplication
    {
        private readonly IAlunoServiceDomain _alunoServiceDomain;
        private readonly IMapper _mapper;

        public AlunoServiceApplication(IAlunoServiceDomain alunoServiceDomain, IMapper mapper) : base(alunoServiceDomain)
        {
            _alunoServiceDomain = alunoServiceDomain;
            _mapper = mapper;
        }

        public void AdicionarAluno(AlunoViewModel aluno)
        {
            _alunoServiceDomain.Adicionar(_mapper.Map<Aluno>(aluno));
        }

        public void AtualizarAluno(AlunoViewModel aluno)
        {
            throw new NotImplementedException();
        }

        public AlunoViewModel DetalharPorNome(string busca)
        {
            throw new NotImplementedException();
        }

        public void ExcluirAluno(AlunoViewModel aluno)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AlunoViewModel> ListarAlunos()
        {
            var al = _alunoServiceDomain.Listar();
            return _mapper.Map<List<AlunoViewModel>>(al);
        }

        public IEnumerable<AlunoViewModel> ListarAlunosAtivos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AlunoViewModel> ListarAlunosInadimplentes()
        {
            throw new NotImplementedException();
        }

        public AlunoViewModel ObterAlunoPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public AlunoViewModel ObterAlunoPorNome(string busca)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SelectListItem> ObterListaAlunosForDropDown()
        {
            return _alunoServiceDomain.ObterListaAlunosForDropDown();
        }
    }
}
