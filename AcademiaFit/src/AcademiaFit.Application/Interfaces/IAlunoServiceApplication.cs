using AcademiaFit.Application.ViewModels;
using AcademiaFit.Domain.Models;
using AcademiaFit.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Application.Interfaces
{
    public interface IAlunoServiceApplication : IBaseServiceApplication<Aluno>
    {
        void AdicionarAluno(AlunoViewModel obj);
        AlunoViewModel DetalharAluno(int id);
        IEnumerable<AlunoViewModel> ListarAlunos();
        void AtualizarAluno(AlunoViewModel obj);
        void ExcluirAluno(AlunoViewModel obj);

        Aluno DetalharPorNome(string busca);
        IEnumerable<Aluno> ListarAlunosAtivos();
        IEnumerable<Aluno> ListarAlunosInadimplentes();
    }
}
