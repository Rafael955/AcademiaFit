using AcademiaFit.Application.ViewModels;
using AcademiaFit.Domain.Models;
using AcademiaFit.Domain.Models.Aggregates.SerieAggregate;
using AcademiaFit.Domain.Models.Entity;
using AutoMapper;

namespace AcademiaFit.Infrastructure.Data.AutoMapper
{
    public class DomainToViewModelMapping : Profile
    {
        public DomainToViewModelMapping()
        {
            CreateMap<Aluno, AlunoViewModel>()
                .ConvertUsing((src, dst) =>
                {
                    return new AlunoViewModel
                    {
                        Id = src.Id,
                        Ativo = src.Ativo,
                        Celular = src.Celular,
                        CPF = src.CPF,
                        DataNascimento = src.DataNascimento,
                        Email = src.Email,
                        Endereco = new EnderecoViewModel
                        {
                            Bairro = src.Endereco.Bairro,
                            CEP = src.Endereco.CEP,
                            Cidade = src.Endereco.Cidade,
                            Estado = src.Endereco.Estado,
                            Logradouro = src.Endereco.Logradouro,
                            Municipio = src.Endereco.Municipio,
                            UF = src.Endereco.UF
                        },
                        Nome = src.Nome,
                        NomeCompleto = string.Concat(src.Nome, " ", src.Sobrenome),
                        Sobrenome = src.Sobrenome,
                        Telefone = src.Telefone
                    };
                });

            CreateMap<Professor, ProfessorViewModel>()
                .ConvertUsing((src, dst) =>
                {
                    return new ProfessorViewModel
                    {
                        Id = src.Id,
                        Ativo = src.Ativo,
                        Celular = src.Celular,
                        CPF = src.CPF,
                        CREF = src.CREF,
                        DataNascimento = src.DataNascimento,
                        Email = src.Email,
                        Endereco = new EnderecoViewModel
                        {
                            Bairro = src.Endereco.Bairro,
                            CEP = src.Endereco.CEP,
                            Cidade = src.Endereco.Cidade,
                            Estado = src.Endereco.Estado,
                            Logradouro = src.Endereco.Logradouro,
                            Municipio = src.Endereco.Municipio,
                            UF = src.Endereco.UF
                        },
                        Nome = src.Nome,
                        NomeCompleto = string.Concat(src.Nome, " ", src.Sobrenome),
                        Sobrenome = src.Sobrenome,
                        Telefone = src.Telefone
                    };
                });

            CreateMap<Serie, SerieViewModel>()
                .ConvertUsing((src, dst) =>
                {
                    return new SerieViewModel
                    {
                        Serie = new Serie
                        {
                            AlunoId = src.AlunoId,
                            ProfessorResponsavelId = src.ProfessorResponsavelId
                        }
                    };
                });
        }
    }
}





