using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Business
{
    public static class EncryptionHelper
    {
        private static readonly string key = "1234567891234567"; // Replace with a secure key

        public static string Encrypt(string plainText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (var msEncrypt = new MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (var swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }

                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        public static string Decrypt(string cipherText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (var msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var srDecrypt = new StreamReader(csDecrypt))
                {
                    return srDecrypt.ReadToEnd();
                }
            }
        }


        static public void ClearEncryptedPassword()
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\HospitalManagmentSystem"))
            {
                if (key != null)
                {
                    key.SetValue("Username", string.Empty);
                    key.SetValue("Password", string.Empty);
                }
            }
        }
        public static  void SaveEncryptedPasswordIfNotExists(string username, string password)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\HospitalManagmentSystem"))
            {
                if (key != null)
                {
                    string existingUsername = key.GetValue("Username") as string;
                    string existingEncryptedPassword = key.GetValue("Password") as string;

                    if (string.IsNullOrEmpty(existingUsername) || string.IsNullOrEmpty(existingEncryptedPassword))
                    {
                        string encryptedPassword = EncryptionHelper.Encrypt(password);
                        key.SetValue("Username", username);
                        key.SetValue("Password", encryptedPassword);
                    }
                }
            }
        }


        public static bool GetUsernameAndPassword(out string username, out string password)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\HospitalManagmentSystem"))
            {
                if (key != null)
                {
                    username = key.GetValue("Username") as string;
                    string encryptedPassword = key.GetValue("Password") as string;
                    password = EncryptionHelper.Decrypt(encryptedPassword);
                    return true;
                }
                else
                {
                    username = null;
                    password = null;
                    return false;
                }
            }
        }
    }

 
   

}
