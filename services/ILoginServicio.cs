using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using proyecto_santiago.Models;

namespace proyecto_santiago.services
{
    public interface ILoginServicio
    {
       public Task<usuarioModel1?> Login(Loginmodel login);
    }
}