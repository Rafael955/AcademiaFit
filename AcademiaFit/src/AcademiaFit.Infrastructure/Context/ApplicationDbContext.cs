using AcademiaFit.Domain.Models;
using AcademiaFit.Domain.Models.Aggregates;
using AcademiaFit.Domain.Models.Aggregates.SerieAggregate;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AcademiaFit.Infrastructure.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Recepcionista> Recepcionistas { get; set; }
        public DbSet<AvaliacaoFisica> AvaliacoesFisicas { get; set; }
        public DbSet<MedidasCorporais> MedidasCorporais { get; set; }
        public DbSet<Equipamento> Equipamento { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<ItemSerie> ItensSeries { get; set; }
        public DbSet<Exercicio> Exercicios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
