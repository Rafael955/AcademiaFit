using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Models.Entity
{
    public abstract class Pessoa : Entidade
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
        public string CPF { get; set; }
        public bool Ativo { get; set; }
    }
}
