using AcademiaFit.Domain.Interfaces.IRepository;
using AcademiaFit.Domain.Models;
using AcademiaFit.Infrastructure.Data.Context;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademiaFit.Infrastructure.Data.Repository
{
    public class ProfessorRepository : BaseRepository<Professor>, IProfessorRepository
    {
        private ApplicationDbContext _context;

        public ProfessorRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public override IEnumerable<Professor> Listar()
        {
            return _context.Set<Professor>().Include(x => x.Endereco).ToList();
        }

        public IEnumerable<Professor> ListarAvaliacoesFisicasDoProfessor()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Professor> ListarProfessoresAtivos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Professor> ListarSeriesDoProfessor()
        {
            throw new NotImplementedException();
        }

        public Professor ObterProfessorPorNome(string busca)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SelectListItem> ObterListaProfessoresForDropDown()
        {
            return _context.Professores.Select(x => new SelectListItem()
            {
                Text = x.Nome,
                Value = x.Id.ToString()
            });
        }
    }
}
