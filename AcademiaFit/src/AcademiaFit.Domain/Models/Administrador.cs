using AcademiaFit.Domain.Models.Entity;
using AcademiaFit.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Models
{
    public class Administrador : Entidade
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public Email Email { get; set; }
        public Endereco Endereco { get; set; }
        public CPF CPF { get; set; }
    }
}
