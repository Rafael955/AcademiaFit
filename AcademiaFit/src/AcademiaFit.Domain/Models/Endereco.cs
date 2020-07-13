using AcademiaFit.Domain.Models.Entity;

using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Domain.Models
{
    public class Endereco : Entidade
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }
    }
}
