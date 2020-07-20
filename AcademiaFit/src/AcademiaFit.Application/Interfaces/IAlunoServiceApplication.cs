using AcademiaFit.Application.ViewModels;
using AcademiaFit.Domain.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Application.Interfaces
{
    public interface IAlunoServiceApplication : IBaseServiceApplication<Aluno>
    {
        void AdicionarAluno(AlunoViewModel aluno);
        AlunoViewModel ObterAlunoPorId(Guid id);
        IEnumerable<AlunoViewModel> ListarAlunos();
        void AtualizarAluno(AlunoViewModel aluno);
        void ExcluirAluno(AlunoViewModel aluno);

        AlunoViewModel ObterAlunoPorNome(string busca);
        IEnumerable<AlunoViewModel> ListarAlunosAtivos();
        IEnumerable<AlunoViewModel> ListarAlunosInadimplentes();
        IEnumerable<SelectListItem> ObterListaAlunosForDropDown();
    }
}
