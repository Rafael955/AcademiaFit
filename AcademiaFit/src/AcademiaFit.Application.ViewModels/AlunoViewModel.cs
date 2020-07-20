using System;
using System.ComponentModel.DataAnnotations;

namespace AcademiaFit.Application.ViewModels
{
    public class AlunoViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(255, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(255, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 2)]
        public string Sobrenome { get; set; }

        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date, ErrorMessage = "{0} em formato inválido.")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(15, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 8)]
        [RegularExpression(@"^\([1-9]{2}\) (?:[2-8])[0-9]{3}\-[0-9]{4}$", ErrorMessage = "Número {0} em formato inválido.")]
        public string Telefone { get; set; }

        [StringLength(15, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 9)]
        [RegularExpression(@"^\([1-9]{2}\) (?:9[1-9])[0-9]{3}\-[0-9]{4}$", ErrorMessage = "Número {0} em formato inválido.")]
        public string Celular { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "{0} em formato inválido.")]
        public string Email { get; set; }

        public EnderecoViewModel Endereco { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string CPF { get; set; }

        [Display(Name = "Ativo?")]
        public bool Ativo { get; set; }
    }
}
