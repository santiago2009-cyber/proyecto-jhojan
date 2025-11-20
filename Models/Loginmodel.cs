using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_santiago.Models
{
    public class Loginmodel
    {
        public required string Login_Correo { get; set; }
        [Required(ErrorMessage = "La Contraseña es obligatorio.")]
        [MinLength(6, ErrorMessage ="La Contraseña debe tener al menos 6 caracteres.m")]
        public required string Login_Contrasena { get; set; }
    }
}