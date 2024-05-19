using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccessLayer
{
    public class HospitalInfoData
    {
        public static int AddNew(string HospitalName, string HospitalPhone, string HospitalLogo, string HospitalAddress)
        {
            int HospitalID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"EXEC SP_AddNewHospital
                     @HospitalName = @HospitalName,
                     @HospitalPhone = @HospitalPhone,
                     @HospitalLogo = @HospitalLogo,
                     @HospitalAddress = @HospitalAddress;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@HospitalName", HospitalName);
                        command.Parameters.AddWithValue("@HospitalPhone", HospitalPhone);
                        command.Parameters.AddWithValue("@HospitalLogo", HospitalLogo);
                        command.Parameters.AddWithValue("@HospitalAddress", HospitalAddress);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            HospitalID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
                // Handle or log the exception here
            }

            return HospitalID;
        }

        public static bool Update(int HospitalID, string HospitalName, string HospitalPhone, string HospitalLogo, string HospitalAddress)
        {
            int RowAffected = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"EXEC SP_UpdateHospital
                     @HospitalID = @HospitalID,
                     @HospitalName = @HospitalName,
                     @HospitalPhone = @HospitalPhone,
                     @HospitalLogo = @HospitalLogo,
                     @HospitalAddress = @HospitalAddress;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@HospitalID", HospitalID);
                        command.Parameters.AddWithValue("@HospitalName", HospitalName);
                        command.Parameters.AddWithValue("@HospitalPhone", HospitalPhone);
                        command.Parameters.AddWithValue("@HospitalLogo", HospitalLogo);
                        command.Parameters.AddWithValue("@HospitalAddress", HospitalAddress);

                        RowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
                // Handle or log the exception here
            }

            return (RowAffected > 0);
        }

        public static bool Delete(int HospitalID)
        {
            int RowAffected = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"EXEC SP_DeleteHospital
                            @HospitalID = @HospitalID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@HospitalID", HospitalID);

                        RowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
                // Handle or log the exception here
            }

            return (RowAffected > 0);
        }

        public static bool Find(int HospitalID, out string HospitalName, out string HospitalPhone, out string HospitalLogo, out string HospitalAddress)
        {
            bool isFound = false;
            HospitalName = "";
            HospitalPhone = "";
            HospitalLogo = "";
            HospitalAddress = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"EXEC SP_GetHospitalByID
                            @HospitalID = @HospitalID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@HospitalID", HospitalID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    isFound = true;
                                    HospitalName = reader["HospitalName"].ToString();
                                    HospitalPhone = reader["HospitalPhone"].ToString();
                                    HospitalLogo = reader["HospitalLogo"].ToString();
                                    HospitalAddress = reader["HospitalAddress"].ToString();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
            }

            return isFound;
        }

        public static DataTable GetAllHospitals()
        {
            DataTable dtHospitals = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"EXEC SP_GetAllHospitals ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtHospitals.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
            }

            return dtHospitals;
        }

        public static bool IsHospitalExist(int HospitalID)
        {
            bool isExist = false;

            try
            {
                string query = @"SP_IsHospitalExist 
                         HospitalID=@HospitalID ";
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@HospitalID", HospitalID);

                        object resulte = command.ExecuteScalar();

                        if (resulte != null && (int)resulte == 1)
                        {
                            isExist = true;
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
                // Handle or log the exception here
            }
            return isExist;
        }
    }
}


