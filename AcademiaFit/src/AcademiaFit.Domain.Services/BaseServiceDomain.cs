using AcademiaFit.Domain.Interfaces.IRepository;
using AcademiaFit.Domain.Interfaces.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Services
{
    public abstract class BaseServiceDomain<T> : IDisposable, IBaseServiceDomain<T> where T : class
    {
        private readonly IBaseRepository<T> _repository;

        public BaseServiceDomain(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public void Adicionar(T obj)
        {
            _repository.Adicionar(obj);
        }

        public void Atualizar(T obj)
        {
            _repository.Atualizar(obj);
        }

        public void Excluir(T obj)
        {
            _repository.Excluir(obj);
        }

        public IEnumerable<T> Listar()
        {
            return _repository.Listar();
        }

        public T ObterPorId(Guid id)
        {
            return _repository.ObterPorId(id);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
