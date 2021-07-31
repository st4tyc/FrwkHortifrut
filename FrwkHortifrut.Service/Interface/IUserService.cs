using FrwkHortifrut.Dominio.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrwkHortifrut.Service.Interface
{
    public interface IUserService
    {
        UserModel ObterUsuario(string username, string password);
        public string GenerateToken(UserModel userModel);
    }
}
