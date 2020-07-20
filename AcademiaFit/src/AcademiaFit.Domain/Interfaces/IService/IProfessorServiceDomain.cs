using AcademiaFit.Domain.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace AcademiaFit.Domain.Interfaces.IService
{
    public interface IProfessorServiceDomain : IBaseServiceDomain<Professor>
    {
        Professor ObterProfessorPorNome(string busca);
        IEnumerable<Professor> ListarProfessoresAtivos();
        IEnumerable<Professor> ListarSeriesDoProfessor();
        IEnumerable<Professor> ListarAvaliacoesFisicasDoProfessor();
        IEnumerable<SelectListItem> ObterListaProfessoresForDropDown();
    }
}
