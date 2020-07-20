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
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
    {
        private ApplicationDbContext _context; 

        public AlunoRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }


        public Aluno DetalharPorNome(string busca)
        {
            throw new NotImplementedException();
        }
        public override IEnumerable<Aluno> Listar()
        {
            return _context.Set<Aluno>().Include(x => x.Endereco).ToList();
        }

        public IEnumerable<Aluno> ListarAlunosAtivos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aluno> ListarAlunosInadimplentes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SelectListItem> ObterListaAlunosForDropDown()
        {
            return _context.Alunos.Select(x => new SelectListItem()
            {
                Text = x.Nome,
                Value = x.Id.ToString()
            });
        }
    }
}
