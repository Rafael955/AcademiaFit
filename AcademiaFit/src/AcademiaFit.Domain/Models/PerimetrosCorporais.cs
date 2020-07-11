using AcademiaFit.Domain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Models.Aggregates
{
    public class PerimetrosCorporais : Entidade
    {
        public decimal BracoEsquerdo { get; set; }
        public decimal BracoDireito { get; set; }
        public decimal AntebracoEsquerdo { get; set; }
        public decimal AntebracoDireito { get; set; }
        public decimal Torax { get; set; }
        public decimal Cintura { get; set; }
        public decimal Ombros { get; set; }
        public decimal CoxaEsquerda { get; set; }
        public decimal CoxaDireita { get; set; }
        public decimal PernaEsquerda { get; set; }
        public decimal PernaDireita { get; set; }

        public Guid AlunoId { get; set; }
        public Aluno Aluno { get; set; }

        public Guid AvaliacaoFisicaId { get; set; }
        public AvaliacaoFisica AvaliacaoFisica { get; set; }
    }
}
