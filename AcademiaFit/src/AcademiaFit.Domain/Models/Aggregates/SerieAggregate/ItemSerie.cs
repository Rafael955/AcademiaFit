using AcademiaFit.Domain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Models.Aggregates.SerieAggregate
{
    public class ItemSerie : Entidade
    {
        public Serie Serie { get; set; }
        public Exercicio Exercicio { get; set; }
        public int NumeroSeries { get; set; }
        public int NumeroRepeticoes { get; set; }
        public string Observacoes { get; set; }
    }
}
