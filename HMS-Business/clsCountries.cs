using HMS_DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace HMS_DataBusinessLayer
{
    public class clsCountries
    {
        public int CountryID { private set; get; }
        public string CountryName { set; get; }
        public clsCountries()
        {
            CountryID = -1;
            CountryName = "";
        }
        private clsCountries(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }
        public static clsCountries GetCountry(int CountryID)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("CountryID",CountryID);
            parameters[1] = new SqlParameter("CountryName", null);
            if ( clsCoutriesData.GetCountry(ref parameters))
                return new clsCountries((int)parameters[0].Value,parameters[1].Value.ToString());
            else return null;
        }
        public static clsCountries GetCountry(string CountryName)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0].ParameterName = "CountryName";
            parameters[1].Value = CountryName;
            if (clsCoutriesData.GetCountry(ref parameters))
                return new clsCountries((int)parameters[0].Value, parameters[1].Value.ToString());
            else return null;
        }
        public static DataTable GetAllCountries()
        {
            return clsCoutriesData.GetAllCountries();
        }
    }
}
