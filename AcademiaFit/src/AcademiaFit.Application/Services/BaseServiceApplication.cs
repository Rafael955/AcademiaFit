using AcademiaFit.Application.Interfaces;
using AcademiaFit.Domain.Interfaces.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Application.Services
{
    public class BaseServiceApplication<T> : IDisposable, IBaseServiceApplication<T> where T : class
    {
        private readonly IBaseServiceDomain<T> _serviceDomain;

        public BaseServiceApplication(IBaseServiceDomain<T> serviceDomain)
        {
            _serviceDomain = serviceDomain;
        }

        public virtual void Adicionar(T obj)
        {
            _serviceDomain.Adicionar(obj);
        }

        public virtual void Atualizar(T obj)
        {
            _serviceDomain.Atualizar(obj);
        }

        public virtual void Excluir(T obj)
        {
            _serviceDomain.Excluir(obj);
        }

        public virtual IEnumerable<T> Listar()
        {
            return _serviceDomain.Listar();
        }

        public virtual T ObterPorId(Guid id)
        {
            return _serviceDomain.ObterPorId(id);
        }

        public void Dispose()
        {
            _serviceDomain.Dispose();
        }
    }
}
