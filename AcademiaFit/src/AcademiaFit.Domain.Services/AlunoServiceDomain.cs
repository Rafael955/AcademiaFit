using AcademiaFit.Domain.Interfaces.IRepository;
using AcademiaFit.Domain.Interfaces.IService;
using AcademiaFit.Domain.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Services
{
    public class AlunoServiceDomain : BaseServiceDomain<Aluno>, IAlunoServiceDomain
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoServiceDomain(IAlunoRepository alunoRepository) : base(alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }
        // TODO: Programar possíveis validações/regras de negócio aqui nesta camada.
        public Aluno ObterAlunoPorNome(string busca)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aluno> ListarAlunosAtivos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aluno> ListarAlunosInadimplentes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SelectListItem> ObterListaAlunosForDropDown()
        {
            return _alunoRepository.ObterListaAlunosForDropDown();
        }
    }
}
