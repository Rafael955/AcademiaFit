using AcademiaFit.Domain.Models.Entity;
using System;
using System.Collections.Generic;
namespace AcademiaFit.Domain.Models.Aggregates.SerieAggregate
{
    public class Serie : Entidade
    {
        public Guid ProfessorResponsavelId { get; set; }
        public Professor ProfessorResponsavel { get; set; }

        public Guid AlunoId { get; set; }
        public Aluno Aluno { get; set; }

        public IEnumerable<ItemSerie> ItemsDaSerie { get; set; }
    }
}
