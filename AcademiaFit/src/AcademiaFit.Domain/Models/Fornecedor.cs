using AcademiaFit.Domain.Models.Entity;
using AcademiaFit.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Models
{
    public class Fornecedor : Entidade
    {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public Email Email { get; set; }
        public Endereco Endereco { get; set; }
        public CNPJ CNPJ { get; set; }
    }
}
