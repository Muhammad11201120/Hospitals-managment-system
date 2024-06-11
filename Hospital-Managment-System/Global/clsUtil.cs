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

        public static string ComputeHash(string Data)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Data));

                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }
}
