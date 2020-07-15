using AcademiaFit.Domain.Interfaces.IRepository;
using AcademiaFit.Domain.Models;
using System;
using System.Collections.Generic;

namespace AcademiaFit.Infrastructure.Repository
{
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
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
