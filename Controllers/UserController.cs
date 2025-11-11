using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proyecto_santiago.implementación;
using proyecto_santiago.Models;
using proyecto_santiago.services;

namespace proyecto_santiago.Controllers
{
    [Route("user")]

    public class UserController : Controller
    {
        private readonly IUserService usuarioService;

        public UserController(IUserService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(usuarioModel1 usuario)
        {
            if (usuario != null)
            {
                usuarioService.CrearUsuario(usuario);
                return Ok("usuario creado");
            }
            else
            {
                return BadRequest("Usuario no puede ser null");


            }
        }
        [HttpGet]
        [Route("register")]

        public  IActionResult Register()
        {
            return View();
        }
    }
}