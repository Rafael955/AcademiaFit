using AcademiaFit.Domain.Interfaces.IRepository;
using AcademiaFit.Domain.Models.Aggregates.SerieAggregate;
using AcademiaFit.Infrastructure.Data.Context;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AcademiaFit.Infrastructure.Data.Repository
{
    public class SerieRepository : BaseRepository<Serie>, ISerieRepository
    {
        private ApplicationDbContext _context; 
        public IConfiguration Configuration { get; }

        public SerieRepository(ApplicationDbContext context, IConfiguration configuration) : base(context)
        {
            _context = context;
            Configuration = configuration;
        }

        public override void Adicionar(Serie serie)
        {
            var connectionString = Configuration.GetConnectionString("DefaultConnection");

            using var connection = new SqlConnection(connectionString);

            //Inserindo Série(Serie)
            var cmdText = "INSERT INTO Series (Id, DataCadastro, ProfessorResponsavelId, AlunoId) VALUES (@Id, @DataCadastro, @ProfessorResponsavelId, @AlunoId)";

            var insertSerie = new SqlCommand(cmdText, connection);
            insertSerie.CommandType = CommandType.Text;

            insertSerie.Parameters.AddWithValue("@Id", serie.Id);
            insertSerie.Parameters.AddWithValue("@DataCadastro", serie.DataCadastro);
            insertSerie.Parameters.AddWithValue("@ProfessorResponsavelId", serie.ProfessorResponsavelId);
            insertSerie.Parameters.AddWithValue("@AlunoId", serie.AlunoId);

            try
            {
                connection.Open();
                insertSerie.ExecuteNonQuery();

                //Inserindo Exercicios da Série(ItemSerie)
                foreach (var itemSerie in serie.ItemsDaSerie)
                {
                    cmdText = $"INSERT INTO ItensSeries ("+
                        $"Id, " +
                        $"DataCadastro, " +
                        $"SerieId, " +
                        $"ExercicioId, " +
                        $"NumeroSeries, " +
                        $"NumeroRepeticoes, " +
                        $"Observacoes) VALUES ("+
                        $"@Id, " +
                        $"@DataCadastro, " +
                        $"@SerieId, " +
                        $"@ExercicioId, " +
                        $"@NumeroSeries, " +
                        $"@NumeroRepeticoes, " +
                        $"@Observacoes)";

                    var insertItemSerie = new SqlCommand(cmdText, connection);
                    insertItemSerie.CommandType = CommandType.Text;

                    insertItemSerie.Parameters.AddWithValue("@Id", itemSerie.Id);
                    insertItemSerie.Parameters.AddWithValue("@DataCadastro", itemSerie.DataCadastro);
                    insertItemSerie.Parameters.AddWithValue("@SerieId", serie.Id);
                    insertItemSerie.Parameters.AddWithValue("@ExercicioId", itemSerie.ExercicioId);
                    insertItemSerie.Parameters.AddWithValue("@NumeroSeries", itemSerie.NumeroSeries);
                    insertItemSerie.Parameters.AddWithValue("@NumeroRepeticoes", itemSerie.NumeroRepeticoes);
                    insertItemSerie.Parameters.AddWithValue("@Observacoes", itemSerie.Observacoes);

                    insertItemSerie.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                connection.Close();
            }
        }

        public override IEnumerable<Serie> Listar()
        {
            return _context.Series.Include(x => x.ItemsDaSerie).ToList();
        }

        public IEnumerable<Serie> ListarSeriesPorNomeAluno(string busca)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Serie> ListarSeriesPorNomeProfessor(string busca)
        {
            throw new NotImplementedException();
        }

        public void RemoverItemDaSerie(ItemSerie itemSerie)
        {
            _context.ItensSeries.Remove(itemSerie);
            _context.SaveChanges();
        }
    }
}
