using AcademiaFit.Domain.Models.Aggregates;
using AcademiaFit.Domain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Models
{
    public class AvaliacaoFisica : Entidade
    {
        public DateTime DataAvaliacao { get; set; }

        public Guid AlunoId { get; set; }
        public Aluno Aluno { get; set; }

        public Guid ProfessorId { get; set; }
        public Professor ProfessorResponsavel { get; set; }
    }
}
