using FrwkHortifrut.Data.Repository;
using FrwkHortifrut.Dominio.Model;
using FrwkHortifrut.Service.Interface;
using System.Collections.Generic;

namespace FrwkHortifrut.Service.Service
{
    public class FrutaService : IFrutaService
    {
        private readonly IFrutaRepository _frutaRepository;

        public FrutaService(IFrutaRepository frutaRepository)
        {
            _frutaRepository = frutaRepository;
        }
        public bool AtualizarFruta(FrutaModel frutaModel)
        {
            return _frutaRepository.Atualizar(frutaModel).Result>0;
        }

        public bool ExcluirFruta(int id)
        {
            return _frutaRepository.Excluir(id).Result ;
        }

        public int IncluirFruta(FrutaModel frutaModel)
        {
            return _frutaRepository.Incluir(frutaModel).Result;
        }

        public IEnumerable<FrutaModel> ObterFrutas()
        {
            return _frutaRepository.ObterTodos().Result;
        }
    }
}
