using AcademiaFit.Domain.Models.Aggregates;
using AcademiaFit.Domain.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AcademiaFit.Domain.Models
{
    public class AvaliacaoFisica : Entidade
    {
        public DateTime DataAvaliacao { get; set; }

        [Required]
        public Guid AlunoId { get; set; }

        [ForeignKey("AlunoId")]
        public Aluno Aluno { get; set; }

        [Required]
        public Guid ProfessorId { get; set; }

        [ForeignKey("ProfessorId")]
        public Professor ProfessorResponsavel { get; set; }
    }
}
