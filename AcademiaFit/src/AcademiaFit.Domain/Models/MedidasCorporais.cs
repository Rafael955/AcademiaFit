using AcademiaFit.Domain.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public double MassaMagra { get; set; }
        public double MassaGorda { get; set; }

        #region Perimetros Corporais
        public double BracoEsquerdo { get; set; }
        public double BracoDireito { get; set; }
        public double AntebracoEsquerdo { get; set; }
        public double AntebracoDireito { get; set; }
        public double Torax { get; set; }
        public double Cintura { get; set; }
        public double Ombros { get; set; }
        public double CoxaEsquerda { get; set; }
        public double CoxaDireita { get; set; }
        public double PernaEsquerda { get; set; }
        public double PernaDireita { get; set; }
        #endregion

        #region Entity Framework Relationships

        [Required]
        public Guid AlunoId { get; set; }

        [ForeignKey("AlunoId")]
        public Aluno Aluno { get; set; }

        [Required]
        public Guid AvaliacaoFisicaId { get; set; }

        [ForeignKey("AvaliacaoFisicaId")]
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
