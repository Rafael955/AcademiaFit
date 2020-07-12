using AcademiaFit.Domain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Models.Aggregates
{
    public class MedidasCorporais : Entidade
    {
        public MedidasCorporais()
        {
            CalculoIMC();
        }

        public double Peso { get; set; }
        public double Altura { get; set; }
        public string IMC { get; private set; }
        public double PercentualGordura { get; set; }

        #region Perimetros Corporais
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
        #endregion

        #region Entity Framework Relationships
        public Guid AlunoId { get; set; }
        public Aluno Aluno { get; set; }

        public Guid AvaliacaoFisicaId { get; set; }
        public AvaliacaoFisica AvaliacaoFisica { get; set; }
        #endregion

        private void CalculoIMC()
        {
            var imc = Peso / (Altura * Altura);

            if(imc < 17)
            {
                IMC = "Muito abaixo do peso";
            }
            else if(imc >=17 && imc <= 18.49)
            {
                IMC = "Abaixo do peso";
            }
            else if (imc >= 18.5 && imc <= 24.99)
            {
                IMC = "Peso normal";
            }
            else if (imc >= 25 && imc <= 29.99)
            {
                IMC = "Acima do peso";
            }
            else if (imc >= 30 && imc <= 34.99)
            {
                IMC = "Obesidade I";
            }
            else if(imc >= 35 && imc <= 39.99)
            {
                IMC = "Obesidade II (severa)";
            }
            else
            {
                IMC = "Obesidade III (mórbida)";
            }
        }
    }
}
