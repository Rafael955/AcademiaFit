﻿using AcademiaFit.Domain.Interfaces.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Services
{
    public abstract class BaseServiceDomain<T> : IDisposable, IBaseServiceDomain<T> where T : class
    {
        public void Adicionar(T obj)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(T obj)
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

        public T ObterPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}