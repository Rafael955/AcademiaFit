using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Application.Interfaces
{
    public interface IBaseServiceApplication<T> where T : class
    {
        void Adicionar(T obj);
        T ObterPorId(Guid id);
        IEnumerable<T> Listar();
        void Atualizar(T obj);
        void Excluir(T obj);
        void Dispose();
    }
}
