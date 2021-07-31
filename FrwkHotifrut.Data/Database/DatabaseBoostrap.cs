
using Dapper;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace FrwkHortifrut.Data.Database
{
    public class DatabaseBoostrap : IDatabaseBoostrap
    {
        private readonly IConfiguration _configuration;

        public DatabaseBoostrap( IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void Setup()
        {
            using var connection = new SqliteConnection($"Data Source={ _configuration.GetSection("DatabaseName").Value}");

            var table = connection.Query<string>("SELECT NAME FROM sqlite_master WHERE type='table' AND name='fruta'; ");

            if (table.Count() > 0)
                return;

            connection.Execute($"CREATE TABLE fruta (" +
                $"Id INTEGER PRIMARY KEY AUTOINCREMENT" +
                $",Nome VARCHAR(200) " +
                $",Descricao VARCHAR(200)" +
                $",Foto Blob null" +
                $",QuantidadeEstoque INT " +
                $",Valor money);");

        }
    }
}
