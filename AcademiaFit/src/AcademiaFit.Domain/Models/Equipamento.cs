using AcademiaFit.Domain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Models
{
    public class Equipamento : Entidade
    {
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
