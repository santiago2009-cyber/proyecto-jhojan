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
        public string HashPassword(string password,  out string salt)
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
    }
}