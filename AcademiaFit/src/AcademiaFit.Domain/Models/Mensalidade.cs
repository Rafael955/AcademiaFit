using AcademiaFit.Domain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Models
{
    public class Mensalidade : Entidade
    {
        public DateTime DataVencimento { get; set; }
        public decimal ValorMensalidade { get; set; }
        public Aluno Aluno { get; set; }
    }
}
