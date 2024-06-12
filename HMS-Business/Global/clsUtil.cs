using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment_System.Global
{
    public class clsUtil
    {
        public static bool GetStoredHospitalID(ref string HospitalID)
        {
            try
            {
                string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\Hospital";
                string ValueName = "HospitalID";

                string line = Registry.GetValue(keyPath, ValueName, null) as string;

                if (line != null)
                {

                    HospitalID = line;
                    return true;
                }
                else
                {
                    Console.WriteLine($"Hospital ID not found.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public static bool RememberHospitalID(string HospitalID)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\Hospital";
            string Value = HospitalID;
            string ValueName = "HospitalID";

            try
            {
                // Write the value to the Registry
                Registry.SetValue(keyPath, ValueName, Value, RegistryValueKind.String);
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }

        }

        public static bool RemoveStoredHospitalID()
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\Hospital";
            string ValueName = "Hospital_ID";

            try
            {
                // Open the registry key in read/write mode with explicit registry view
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath))
                {
                    if (key != null)
                    {
                        key.DeleteValue(ValueName);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        protected static string Key = "1234567891234567";
       public static string Encrypt(string plainText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Set the key and IV for AES encryption
                aesAlg.Key = Encoding.UTF8.GetBytes(Key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];


                // Create an encryptor
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);


                // Encrypt the data
                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }


                    // Return the encrypted data as a Base64-encoded string
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }


        public static string Decrypt(string cipherText)
        {
            if(string.IsNullOrEmpty(cipherText))
            {
                return null;
            }
            using (Aes aesAlg = Aes.Create())
            {
                // Set the key and IV for AES decryption
                aesAlg.Key = Encoding.UTF8.GetBytes(Key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];


                // Create a decryptor
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);


                // Decrypt the data
                using (var msDecrypt = new System.IO.MemoryStream(Convert.FromBase64String(cipherText)))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                {
                    // Read the decrypted data from the StreamReader
                    return srDecrypt.ReadToEnd();
                }
            }
        }

       public  static void SaveEncryptedPasswordIfNotExists(string username, string password)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\HospitalManagmentSystem"))
            {
                if (key != null)
                {
                    string existingUsername = key.GetValue("Username") as string;
                    string existingEncryptedPassword = key.GetValue("Password") as string;

                    if (string.IsNullOrEmpty(existingUsername) || string.IsNullOrEmpty(existingEncryptedPassword))
                    {
                        string encryptedPassword = clsUtil.Encrypt(password);
                        key.SetValue("Username", username);
                        key.SetValue("Password", encryptedPassword);
                    }
                }
            }
        }
        public static void  ClearEncryptedPassword()
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

        public static void GetEncryptedCredentials(out string username, out string Password)
        {
            username = null;
            Password = null;
            
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\HospitalManamgentSystem"))
            {
                if (key != null)
                {
                    username = key.GetValue("Username")?.ToString();
                    Password= Decrypt(key.GetValue("Password")?.ToString());
                }
            }
        }

    }
}
