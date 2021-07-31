using System.Collections.Generic;
using FrwkHortifrut.Dominio.Model;
using FrwkHortifrut.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FrwkHortifrut.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FrutaController : ControllerBase
    {
        
        private readonly ILogger<FrutaController> _logger;
        private readonly IFrutaService _frutaService;
        public FrutaController(ILogger<FrutaController> logger, IFrutaService frutaService)
        {
            _logger = logger;
            _frutaService = frutaService;
        }

        [HttpGet]
        [Route("ObterFrutas")]        
        [Authorize]
        public IEnumerable<FrutaModel> ObterFrutas()
        {
            return _frutaService.ObterFrutas();
        }
        [Route("IncluirFruta")]
        [Authorize]
        [HttpPut]
        public int IncluirFruta(FrutaModel frutaModel)
        {
            return _frutaService.IncluirFruta(frutaModel);
        }

        [Route("AtualizarFruta")]
        [Authorize]
        [HttpPost]
        public bool AtualizarFruta(FrutaModel frutaModel)
        {
            return _frutaService.AtualizarFruta(frutaModel);
        }

        [Route("ExcluirFruta")]
        [Authorize]
        [HttpDelete]
        public bool ExcluirFruta(int idFruta)
        {
            return _frutaService.ExcluirFruta(idFruta);
        }
    }
}
