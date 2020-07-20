using AcademiaFit.Domain.Interfaces.IRepository;
using AcademiaFit.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademiaFit.Infrastructure.Data.Repository
{
    public abstract class BaseRepository<T> : IDisposable, IBaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public virtual void Adicionar(T obj)
        {
            try
            {
                _context.Set<T>().Add(obj);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public virtual void Atualizar(T obj)
        {
            throw new NotImplementedException();
        }

        public virtual T ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public virtual void Excluir(T obj)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> Listar()
        {
            return _context.Set<T>().ToList();
        }
    }
}
