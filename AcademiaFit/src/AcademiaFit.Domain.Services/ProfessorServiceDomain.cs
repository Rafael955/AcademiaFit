using AcademiaFit.Domain.Interfaces.IRepository;
using AcademiaFit.Domain.Interfaces.IService;
using AcademiaFit.Domain.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace AcademiaFit.Domain.Services
{
    public class ProfessorServiceDomain : BaseServiceDomain<Professor>, IProfessorServiceDomain
    {
        private readonly IProfessorRepository _professorRepository;
        public ProfessorServiceDomain(IProfessorRepository professorRepository) : base(professorRepository)
        {
            _professorRepository = professorRepository;
        }

        public IEnumerable<Professor> ListarAvaliacoesFisicasDoProfessor()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Professor> ListarProfessoresAtivos()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Professor> ListarSeriesDoProfessor()
        {
            throw new System.NotImplementedException();
        }

        public Professor ObterProfessorPorNome(string busca)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<SelectListItem> ObterListaProfessoresForDropDown()
        {
            return _professorRepository.ObterListaProfessoresForDropDown();
        }
    }
}
