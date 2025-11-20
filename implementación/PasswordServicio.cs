using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using proyecto_santiago.services;

namespace proyecto_santiago.implementación
{
    public class PasswordServicio : IPawordServicio
    {
        public bool Compararcontrasenas(string Contrasena, string ContrasenaBD, string salt)
        {
            byte[] SaltBytes =  Convert.FromBase64String(salt);
            string hashedPasswordtoCheck = EncryptPassword(Contrasena, SaltBytes);
            return hashedPasswordtoCheck == Contrasena;
        }

        public string HashPassword(string password, out string salt)
        {
            String hashedPassword;
            byte[] saltBytes = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            salt = Convert.ToBase64String(saltBytes);
            hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(password: password, salt: saltBytes, prf: KeyDerivationPrf.HMACSHA256, iterationCount: 100000, numBytesRequested: 256 / 8)); return hashedPassword;
        }
        private string EncryptPassword(string Contrasena, byte[] saltBytes)
        {
            string hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(password: Contrasena, salt: saltBytes, prf: KeyDerivationPrf.HMACSHA256, iterationCount: 100000, numBytesRequested: 256 / 8)); 
            return hashedPassword;
        }

    }
}