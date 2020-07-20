using AcademiaFit.Domain.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Interfaces.IRepository
{
    public interface IProfessorRepository : IBaseRepository<Professor>
    {
        Professor ObterProfessorPorNome(string busca);
        IEnumerable<Professor> ListarProfessoresAtivos();
        IEnumerable<Professor> ListarSeriesDoProfessor();
        IEnumerable<Professor> ListarAvaliacoesFisicasDoProfessor();
        IEnumerable<SelectListItem> ObterListaProfessoresForDropDown();
    }
}
