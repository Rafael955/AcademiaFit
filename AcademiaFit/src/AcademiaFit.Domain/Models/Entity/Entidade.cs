using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Models.Entity
{
    public abstract class Entidade
    {
        public Entidade()
        {
            Id = Guid.NewGuid();
            DataCadastro = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public DateTime DataCadastro { get; private set; }
    }
}
