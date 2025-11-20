using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using proyecto_santiago.Data;
using proyecto_santiago.Models;
using proyecto_santiago.services;

namespace proyecto_santiago.implementación
{
    public class LoginServicio : ILoginServicio
    {

        public async Task<usuarioModel1?> Login(Loginmodel login)
        {
            {
                var usuario = await dbContext.Usuarios.FirstOrDefaultAsync(u => u.Usuario_Correo == login.Login_Correo);
                if (usuario == null)
                {
                    return null;
                }
                bool esContrasenaValida = passwordServicio
                .Compararcontrasenas(login.Login_Contrasena, usuario.Usuario_Contrasena, usuario.Usuario_Salt!);
                if (esContrasenaValida)
                {
                    return usuario;
                }
                return null;
            }
        }


        private readonly DBContex dbContext;

        private readonly IPawordServicio passwordServicio;

        public LoginServicio(DBContex dbContext, IPawordServicio pawordServicio)
        {
            this.dbContext = dbContext;
            this.passwordServicio = pawordServicio;
        }
    }
}