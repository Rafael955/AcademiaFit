using AcademiaFit.Domain.Interfaces.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Infrastructure.Repository
{
    public abstract class BaseRepository<T> : IDisposable, IBaseRepository<T> where T : class
    {
        public void Adicionar(T obj)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(T obj)
        {
            throw new NotImplementedException();
        }

        public T DetalharId(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Excluir(T obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
