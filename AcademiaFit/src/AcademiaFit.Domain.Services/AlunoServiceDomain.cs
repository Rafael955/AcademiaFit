using AcademiaFit.Domain.Interfaces.IService;
using AcademiaFit.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Services
{
    public class AlunoServiceDomain : BaseServiceDomain<Aluno>, IAlunoServiceDomain
    {
        public Aluno DetalharPorNome(string busca)
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
    }
}
