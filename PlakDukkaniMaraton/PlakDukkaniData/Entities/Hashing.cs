using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniData.Entities
{
    public class Hashing
    {
        public static string HasHing(string password, string salt)
        {
            using (SHA256 hash = SHA256.Create())
            {
                byte[] saltBytes = Encoding.UTF8.GetBytes(salt);
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);



                byte[] toBeHashed = new byte[passwordBytes.Length + saltBytes.Length];
                Buffer.BlockCopy(passwordBytes, 0, toBeHashed, 0, passwordBytes.Length);
                Buffer.BlockCopy(saltBytes, 0, toBeHashed, passwordBytes.Length, saltBytes.Length);



                return string.Concat(hash.ComputeHash(toBeHashed).Select(b => b.ToString("X2")));
            }
        }
    }
}
