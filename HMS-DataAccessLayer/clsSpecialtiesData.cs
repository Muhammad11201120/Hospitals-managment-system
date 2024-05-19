using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccessLayer
{
    public class clsSpecialityData
    {

        public static int AddNew(string SpecialityName)
        {
            int SpecialityID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"EXEC SP_AddNewSpeciality
                     @SpecialityName = @SpecialityName;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SpecialityName", SpecialityName);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            SpecialityID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
                // Handle or log the exception here
            }

            return SpecialityID;
        }

        public static bool Update(int SpecialityID, string SpecialityName)
        {
            int RowAffected = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"EXEC SP_UpdateSpeciality
                     @SpecialityID = @SpecialityID,
                     @SpecialityName = @SpecialityName;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SpecialityID", SpecialityID);
                        command.Parameters.AddWithValue("@SpecialityName", SpecialityName);

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

        public static bool Delete(int SpecialityID)
        {
            int RowAffected = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"EXEC SP_DeleteSpeciality
                    @SpecialityID = @SpecialityID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SpecialityID", SpecialityID);

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

        public static bool Find(int SpecialityID, out string SpecialityName)
        {
            bool isFound = false;
            SpecialityName = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"EXEC SP_GetSpecialityByID
                    @SpecialityID = @SpecialityID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SpecialityID", SpecialityID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    isFound = true;
                                    SpecialityName = reader["SpecialityName"].ToString();
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

        public static DataTable GetAllSpecialties()
        {
            DataTable dtSpeciality = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"EXEC SP_GetAllSpecialties ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtSpeciality.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
            }

            return dtSpeciality;
        }

        public static bool IsSpecialityExist(int SpecialityID)
        {
            bool isExist = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"SP_IsSpecialityExist 
                 SpecialityID=@SpecialityID ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SpecialityID", SpecialityID);

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
