using AcademiaFit.Domain.Models.Entity;
using AcademiaFit.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Models
{
    public class Endereco : Entidade
    {
        public Endereco()
        {

        }

        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public CEP CEP { get; set; }
        public UF UF { get; set; }
    }
}
