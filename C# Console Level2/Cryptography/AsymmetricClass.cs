using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    public class AsymmetricClass
    {
        /*Main
         try
         {
         using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
         {
         string publicKey = rsa.ToXmlString(false);
         string privateKey = rsa.ToXmlString(true);
         string originalMessage = "Hello, this is a secret message!";
         string encryptedMessage = Encrypt(originalMessage, publicKey);
         string decryptedMessage = Decrypt(encryptedMessage, privateKey);
         Console.WriteLine($"\n\nPublic Key:\n {publicKey}");
         Console.WriteLine($"\n\nPrivate Key:\n {privateKey}");
         Console.WriteLine($"\nOriginal Message:\n {originalMessage}");
         Console.WriteLine($"\nEncrypted Message:\n {encryptedMessage}");
         Console.WriteLine($"\nDecrypted Message:\n {decryptedMessage}");
         Console.WriteLine("\nPress any key to exit...");
         Console.ReadKey();
         }
         }
         catch (CryptographicException ex)
         {
         Console.WriteLine($"Encryption/Decryption error: {ex.Message}");
         Console.ReadKey();
         }
         catch (Exception ex)
         {
         Console.WriteLine($"An unexpected error occurred: {ex.Message}");
         Console.ReadKey();
         }*/

        public static string Encrypt(string plainText, string publicKey)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString(publicKey);


                    byte[] encryptedData = rsa.Encrypt(Encoding.UTF8.GetBytes(plainText), false);
                    return Convert.ToBase64String(encryptedData);
                }
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine($"Encryption error: {ex.Message}");
                throw; // Rethrow the exception to be caught in the Main method
            }
        }

        public static string Decrypt(string cipherText, string privateKey)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString(privateKey);


                    byte[] encryptedData = Convert.FromBase64String(cipherText);
                    byte[] decryptedData = rsa.Decrypt(encryptedData, false);


                    return Encoding.UTF8.GetString(decryptedData);
                }
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine($"Decryption error: {ex.Message}");
                throw; // Rethrow the exception to be caught in the Main method
            }
        }

        static public bool KeysValidation(string publicKey, string privateKey) 
        {
            return true;
        }

        static public void SendSecretMessege(string EncryptedMessege)
        {
            Console.WriteLine("Encrypted messege sent successfully");
        }

        static public void RecieveSecretMessege(string SecretMessege)
        {
            Console.WriteLine($"This is the messege : {SecretMessege}");
        }
    }
}
