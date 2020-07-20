using AcademiaFit.Application.ViewModels;
using AcademiaFit.Domain.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Application.Interfaces
{
    public interface IProfessorServiceApplication : IBaseServiceApplication<Professor>
    {
        void AdicionarProfessor(ProfessorViewModel professor);
        ProfessorViewModel ObterProfessorPorId(Guid id);
        IEnumerable<ProfessorViewModel> ListarProfessores();
        void AtualizarProfessor(ProfessorViewModel professor);
        void ExcluirProfessor(ProfessorViewModel professor);

        ProfessorViewModel ObterProfessorPorNome(string busca);
        IEnumerable<ProfessorViewModel> ListarProfessoresAtivos();
        IEnumerable<ProfessorViewModel> ListarSeriesDoProfessor();
        IEnumerable<ProfessorViewModel> ListarAvaliacoesFisicasDoProfessor();
        IEnumerable<SelectListItem> ObterListaProfessoresForDropDown();
    }
}
