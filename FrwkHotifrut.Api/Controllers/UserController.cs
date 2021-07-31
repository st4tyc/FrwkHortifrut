using FrwkHortifrut.Dominio.Model;
using FrwkHortifrut.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FrwkHortifrut.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
		/// Usuario: admin
        /// Senha: admin
		/// </summary>
        [HttpPost]
        [Route("login")]
        public ActionResult<dynamic> Login([FromBody] UserModel user)
        {
            // Recupera o usuário
            var ususario = _userService.ObterUsuario(user.Username, user.Password);

            // Verifica se o usuário existe
            if (ususario == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            // Gera o Token
            var token = _userService.GenerateToken(user);

            // Oculta a senha
            user.Password = "";

            // Retorna os dados
            return new
            {
                user = user,
                token = token
            };
        }
    }
}
