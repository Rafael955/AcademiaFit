using AcademiaFit.Domain.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AcademiaFit.Domain.Models.Aggregates.SerieAggregate
{
    public class ItemSerie : Entidade
    {
        [Display(Name = "Séries")]
        public int NumeroSeries { get; set; }

        [Display(Name = "Repetições")]
        public int NumeroRepeticoes { get; set; }

        [Display(Name = "Carga")]
        public int Carga { get; set; }

        [Display(Name = "Observações")]
        public string Observacoes { get; set; }

        public Guid SerieId { get; set; }
        public Serie Serie { get; set; }

        public Guid ExercicioId { get; set; }
        public Exercicio Exercicio { get; set; }
    }
}
