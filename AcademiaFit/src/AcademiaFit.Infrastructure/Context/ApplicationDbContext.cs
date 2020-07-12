using AcademiaFit.Domain.Models;
using AcademiaFit.Domain.Models.Aggregates;
using AcademiaFit.Domain.Models.Aggregates.SerieAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AcademiaFit.Infrastructure.Context
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=AcademiaFit;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
