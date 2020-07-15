using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AcademiaFit.Application.ViewModels
{
    public class EnderecoViewModel
    {
        [Display(Name = "Rua")]
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }
    }
}
