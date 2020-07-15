using AcademiaFit.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Interfaces.IService
{
    public interface IAlunoServiceDomain : IBaseServiceDomain<Aluno>
    {
        Aluno DetalharPorNome(string busca);
        IEnumerable<Aluno> ListarAlunosAtivos();
        IEnumerable<Aluno> ListarAlunosInadimplentes();
    }
}
