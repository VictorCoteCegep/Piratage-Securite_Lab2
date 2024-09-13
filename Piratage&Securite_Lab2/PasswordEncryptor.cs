using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Piratage_Securite_Lab2
{
    public class PasswordEncryptor
    {
        public PasswordEncryptor() { }
        public string EncryptPassword(string password)
        {
            using (MD5 MD5hash = MD5.Create())
            {
                // hash
                byte[] bytes = MD5hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Converti les bytes en string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }

}
