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

        public IPawordServicio PasswordService; 

        public UserService(DBContex dbContext, IPawordServicio pawordServicio)
        {
            this.dBContex = dbContext;
            this.PasswordService = pawordServicio;
        }
        

        public async Task CrearUsuario(usuarioModel1 usuario)
        {
            if (usuario != null)
            {
                usuario.Usuario_Contrasena = PasswordService.HashPassword(usuario.Usuario_Contrasena, out string salt);
                usuario.Usuario_Salt = salt; 
                dBContex.Usuarios.Add(usuario);
                await dBContex.SaveChangesAsync();
            }

        }
    }
}