using AcademiaFit.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Interfaces.IRepository
{
    public interface IAlunoRepository : IBaseRepository<Aluno>
    {
        Aluno DetalharPorNome(string busca);
        IEnumerable<Aluno> ListarAlunosAtivos();
        IEnumerable<Aluno> ListarAlunosInadimplentes();
    }
}
