using System;
using System.Configuration;


namespace HMS_DataAccessLayer
{
    static class clsDataAccessSettings
    {
        public static string ConnectionString = Properties.Settings.Default.ConnectionString;
    }


}
