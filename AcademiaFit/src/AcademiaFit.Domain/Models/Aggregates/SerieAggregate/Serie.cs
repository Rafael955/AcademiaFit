using AcademiaFit.Domain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Models.Aggregates.SerieAggregate
{
    public class Serie : Entidade
    {
        public Professor ProfessorResponsavel { get; set; }
        public Aluno Aluno { get; set; }
    }
}
