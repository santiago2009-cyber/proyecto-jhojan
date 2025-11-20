using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace proyecto_santiago.services
{
    public interface IPawordServicio
    {
        String HashPassword(string password,out string salt);
        bool Compararcontrasenas(string Contrasena, string ContrasenaBD, string salt);
    }
}