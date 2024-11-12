using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    public class SymmetricClass
    {
        public static string Encrypt(string password, string key)
        {
            try
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = Encoding.UTF8.GetBytes(key);
                    aes.IV = GetNewBytes(aes.BlockSize / 8);

                    ICryptoTransform crypto = aes.CreateEncryptor(aes.Key, aes.IV);

                    //Write to RAM
                    using (var msEncryptor = new MemoryStream())
                    {
                        using (var csEncryptor = new CryptoStream(msEncryptor, crypto, CryptoStreamMode.Write))
                        using (var swEncryptor = new StreamWriter(csEncryptor))
                        {
                            swEncryptor.Write(password);
                        }

                        return Convert.ToBase64String(msEncryptor.ToArray());
                    }
                }
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return String.Empty;
        }

        public static string Decrypt(string password, string key)
        {
            try
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = Encoding.UTF8.GetBytes(key);
                    aes.IV = GetNewBytes(aes.BlockSize / 8);

                    ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                    //Read from RAM
                    using (var msDecryptor = new MemoryStream(Convert.FromBase64String(password)))
                    using (var csDecryptor = new CryptoStream(msDecryptor, decryptor, CryptoStreamMode.Read))
                    using (var srDecryptor = new StreamReader(csDecryptor))
                        return srDecryptor.ReadToEnd();
                }
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            return String.Empty;
        }

        private static byte[] GetNewBytes(int value)
        {
            return new byte[value];
        }
    }
}
