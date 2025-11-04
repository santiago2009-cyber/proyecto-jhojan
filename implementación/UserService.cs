using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proyecto_santiago.Data;
using proyecto_santiago.Models;
using proyecto_santiago.services;

namespace proyecto_santiago.implementación
{
    public class UserService : IUserService
    {

        private readonly DBContex dBContex;

        public UserService(DBContex dBContex)
        {
            this.dBContex = dBContex;
        }

        public void CrearUsuario(usuarioModel1 usuario)
        {
            if (usuario != null) ;
            {
                dBContex.Usuarios.Add(usuario);
            }

        } 
    }
}