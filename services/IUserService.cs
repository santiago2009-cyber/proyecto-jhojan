using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyecto_santiago.Models;

namespace proyecto_santiago.services
{
    public interface IUserService
    {
        void CrearUsuario(usuarioModel1 usuario);
    }
}