using AcademiaFit.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Application.ViewModels
{
    public class ProfessorViewModel
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public EnderecoViewModel Endereco { get; set; }
        public string CPF { get; set; }
        public string CREF { get; set; }
    }
}
