using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    public class HashingClass
    {
        public static string GenerateSalt(int size = 16)
        {
            byte[] salt = new byte[size];

            try
            {
                using (var rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(salt);
                }
            }
            catch (CryptographicException ex)
            {

                Console.WriteLine(ex.Message);
            }
            return Convert.ToBase64String(salt);
        }

        public static string ComputeHash(string YourData, string salt = "")
        {
            byte[] bytes = default;
            try
            {

                using (SHA256 sha256 = SHA256.Create())
                {
                    string SaltedData = YourData + salt;
                    bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(SaltedData));
                }
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return BitConverter.ToString(bytes).Replace("-", "").ToLower();
        }

        public static bool VerifyData(string UserName, string Password, string salt = "")
        {
            const string myPassword = "e17ab1909f752fdf6c7b8bd87c0ae18ae53cdf24a58a39b658dd021889792377";
            const string myUserName = "d9f73da9afbf6a196401717206a4b99dcbdb0275469c71ef0ea623e8594d61af";
            return myPassword == ComputeHash(Password, salt) && myUserName == ComputeHash(UserName, salt);
        }
    }
}
