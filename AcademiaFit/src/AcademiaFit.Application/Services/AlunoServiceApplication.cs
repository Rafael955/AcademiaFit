using AcademiaFit.Application.Interfaces;
using AcademiaFit.Application.ViewModels;
using AcademiaFit.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Application.Services
{
    public class AlunoServiceApplication : BaseServiceApplication<Aluno>, IAlunoServiceApplication
    {
        public AlunoServiceApplication()
        {

        }

        public void AdicionarAluno(AlunoViewModel obj)
        {
            throw new NotImplementedException();
        }

        public void AtualizarAluno(AlunoViewModel obj)
        {
            throw new NotImplementedException();
        }

        public AlunoViewModel DetalharAluno(int id)
        {
            throw new NotImplementedException();
        }

        public Aluno DetalharPorNome(string busca)
        {
            throw new NotImplementedException();
        }

        public void ExcluirAluno(AlunoViewModel obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AlunoViewModel> ListarAlunos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aluno> ListarAlunosAtivos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aluno> ListarAlunosInadimplentes()
        {
            throw new NotImplementedException();
        }
    }
}
