using Dapper;
using FrwkHortifrut.Dominio.Model;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrwkHortifrut.Data.Repository
{
    public class FrutaRepository : IDisposable, IFrutaRepository
    {
        private readonly IConfiguration _configuration;
        private readonly SqliteConnection _connection;
        public FrutaRepository( IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqliteConnection($"Data Source={ _configuration.GetSection("DatabaseName").Value}");            
        }

        public async Task<int> Incluir(FrutaModel frutaModel)
        {
            return await _connection.ExecuteAsync("INSERT INTO fruta (Nome,Descricao,Foto,QuantidadeEstoque,Valor) " +
                "VALUES (@Nome,@Descricao,@Foto,@QuantidadeEstoque,@Valor);", frutaModel);
        }

        public Task<int> Atualizar(FrutaModel frutaModel)
        {
            return _connection.ExecuteAsync("UPDATE fruta" +
                 " SET Nome=@Nome,Descricao=@Descricao,Foto=@Foto,QuantidadeEstoque=@QuantidadeEstoque,Valor=@Valor WHERE Id = @Id;", frutaModel);
        }

        public async virtual Task<bool> Excluir(int id)
        {
            return await _connection.ExecuteAsync(" DELETE FROM fruta WHERE Id = @Id;", new { Id  = id}) > 0;
        }

        public async Task<IEnumerable<FrutaModel>> ObterTodos()
        {
            return await _connection.QueryAsync<FrutaModel>("SELECT Id, Nome,Descricao,Foto,cast(QuantidadeEstoque  as int) as QuantidadeEstoque,Cast(Valor as Decimal(13,2)) as Valor FROM fruta");
        }

        public void Dispose()
        {
            _connection.Dispose();
        }
    }
}
