using FrwkHortifrut.Dominio.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrwkHortifrut.Data.Repository
{
    public interface IFrutaRepository
    {
        Task<int> Atualizar(FrutaModel frutaModel);
        Task<bool> Excluir(int id);
        void Dispose();
        Task<int> Incluir(FrutaModel frutaModel);
        Task<IEnumerable<FrutaModel>> ObterTodos();
    }
}