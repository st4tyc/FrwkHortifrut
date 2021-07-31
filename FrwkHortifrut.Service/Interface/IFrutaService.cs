using FrwkHortifrut.Dominio.Model;
using System.Collections.Generic;

namespace FrwkHortifrut.Service.Interface
{
    public interface IFrutaService
    {
        IEnumerable<FrutaModel> ObterFrutas();
        int IncluirFruta(FrutaModel frutaModel);
        bool AtualizarFruta(FrutaModel frutaModel);
        bool ExcluirFruta(int id);
    }
}
