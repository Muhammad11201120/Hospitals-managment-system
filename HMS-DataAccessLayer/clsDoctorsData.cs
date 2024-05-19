using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccessLayer
{
    public class clsDoctorsData
    {

        public static int AddNew(int EmployeeID, decimal Price, int SpecialityID)
        {
            int DoctorID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"EXEC SP_AddNewDoctor
                             @EmployeeID = @EmployeeID,
                             @Price = @Price,
                             @SpecialityID = @SpecialityID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                        command.Parameters.AddWithValue("@Price", Price);
                        command.Parameters.AddWithValue("@SpecialityID", SpecialityID);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            DoctorID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
                // Handle or log the exception here
            }

            return DoctorID;
        }

        public static bool Update(int DoctorID, int EmployeeID, decimal Price, int SpecialityID)
        {
            int RowAffected = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"EXEC SP_UpdateDoctor
                             @DoctorID = @DoctorID,
                             @EmployeeID = @EmployeeID,
                             @Price = @Price,
                             @SpecialityID = @SpecialityID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                        command.Parameters.AddWithValue("@Price", Price);
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

        // Other methods remain the same...



        public static bool Delete(int DoctorID)
        {
            int RowAffected = -1;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();

                    string query = @"EXEC  SP_DeleteDoctor
		                            @DoctorID = @DoctorID";
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@DoctorID", DoctorID);

                        RowAffected = Command.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
            }

            return (RowAffected > 0);
        }

        public static bool Find(int DoctorID, out int EmployeeID, out decimal Price, out int SpecialityID)
        {
            bool isFound = false;
            EmployeeID = 0;
            Price = 0;
            SpecialityID = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"EXEC SP_GetDoctorByID
                                @DoctorID = @DoctorID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    isFound = true;
                                    EmployeeID = (int)reader["EmployeeID"];
                                    Price = (decimal)reader["Price"];
                                    SpecialityID = (int) reader["SpecialityID"];
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


        public static DataTable GetAllDoctor()
        {
            DataTable dtDoctor = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();

                    string query = @"exec SP_GetAllDoctor";

                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        using (SqlDataReader reader = Command.ExecuteReader())
                        {

                            if (reader.HasRows)
                                dtDoctor.Load(reader);
                          
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
            }
            return dtDoctor;
        }

        public static bool IsExist(int DoctorID)
        {
            bool isExist = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"EXEC SP_IsDoctorExist
                             @DoctorID = @DoctorID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);

                        object result = command.ExecuteScalar();

                        if (result != null && (int)result == 1)
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

