using HMS_BusinessLayer;
using HMS_DataBusinessLayer;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Managment_System.Global
{
    public class clsGlobal
    {
        public static clsHospitalInfo CurrentHospital;

        public static clsUser CurrnetUser = clsUser.Find(6);

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

        public static bool RemoveStoredCredential()
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


    }
}
