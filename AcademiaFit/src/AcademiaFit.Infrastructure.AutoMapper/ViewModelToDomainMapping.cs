using AcademiaFit.Application.ViewModels;
using AcademiaFit.Domain.Models;
using AcademiaFit.Infrastructure.CrossCutting.Extensions;
using AutoMapper;

namespace AcademiaFit.Infrastructure.Data.AutoMapper
{
    public class ViewModelToDomainMapping : Profile
    {
        public ViewModelToDomainMapping()
        {
            CreateMap<AlunoViewModel, Aluno>()
                .ConvertUsing((src, dst) =>
                {
                    return new Aluno
                    {
                        Ativo = src.Ativo,
                        Celular = src.Celular.RemoveMask(),
                        CPF = src.CPF.RemoveMask(),
                        DataNascimento = src.DataNascimento,
                        Email = src.Email,
                        Endereco = new Endereco
                        {
                            Bairro = src.Endereco.Bairro,
                            CEP = src.Endereco.CEP.RemoveMask(),
                            Cidade = src.Endereco.Cidade,
                            Estado = src.Endereco.Estado,
                            Logradouro = src.Endereco.Logradouro,
                            Municipio = src.Endereco.Municipio,
                            UF = src.Endereco.UF
                        },
                        Nome = src.Nome,
                        Sobrenome = src.Sobrenome,
                        Telefone = src.Telefone.RemoveMask()
                    };
                });

            CreateMap<ProfessorViewModel, Professor>()
                .ConvertUsing((src, dst) =>
                {
                    return new Professor
                    {
                        Ativo = src.Ativo,
                        Celular = src.Celular.RemoveMask(),
                        CPF = src.CPF.RemoveMask(),
                        CREF = src.CREF.RemoveMask(),
                        DataNascimento = src.DataNascimento,
                        Email = src.Email,
                        Endereco = new Endereco
                        {
                            Bairro = src.Endereco.Bairro,
                            CEP = src.Endereco.CEP.RemoveMask(),
                            Cidade = src.Endereco.Cidade,
                            Estado = src.Endereco.Estado,
                            Logradouro = src.Endereco.Logradouro,
                            Municipio = src.Endereco.Municipio,
                            UF = src.Endereco.UF
                        },
                        Nome = src.Nome,
                        Sobrenome = src.Sobrenome,
                        Telefone = src.Telefone.RemoveMask()
                    };
                });
        }
    }
}
