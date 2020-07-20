using System;
using System.Collections.Generic;
using System.Text;
using AcademiaFit.Domain.Models.Entity;


namespace AcademiaFit.Domain.Models
{
    public class Aluno : Pessoa
    {
        public bool Adimplente { get; set; }
    }
}
