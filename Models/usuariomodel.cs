using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_santiago.Models
{
    public class usuarioModel1
    {
        public int UserId { get; set; }
        public required string Usuario_Nombre { get; set; }
        public required string Usuario_Apellidos { get; set; }
        public required string Usuario_Correo { get; set; }
        public required string Usuario_Contrasena { get; set; }
    }
}


