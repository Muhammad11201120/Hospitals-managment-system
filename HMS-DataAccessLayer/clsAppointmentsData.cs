using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccessLayer
{
    public class clsAppointmentsData
    {
        public static int AddNew(int PatientID, int DoctorID, DateTime AppointmentDateTime, string AppointmentStatus, decimal TotalPrice, int UserID)
        {
            int AppointmentID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"EXEC SP_AddNewAppointment
                 @PatientID = @PatientID,
                 @DoctorID = @DoctorID,
                 @AppointmentDateTime = @AppointmentDateTime,
                 @AppointmentStatus = @AppointmentStatus,
                 @TotalPrice = @TotalPrice,
                 @UserID = @UserID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PatientID", PatientID);
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        command.Parameters.AddWithValue("@AppointmentDateTime", AppointmentDateTime);
                        command.Parameters.AddWithValue("@AppointmentStatus", AppointmentStatus);
                        command.Parameters.AddWithValue("@TotalPrice", TotalPrice);
                        command.Parameters.AddWithValue("@UserID", UserID);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            AppointmentID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
                // Handle or log the exception here
            }

            return AppointmentID;
        }

        public static bool Update(int AppointmentID, int PatientID, int DoctorID, DateTime AppointmentDateTime, string AppointmentStatus, decimal TotalPrice, int UserID)
        {
            int RowAffected = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"EXEC SP_UpdateAppointment
                 @AppointmentID = @AppointmentID,
                 @PatientID = @PatientID,
                 @DoctorID = @DoctorID,
                 @AppointmentDateTime = @AppointmentDateTime,
                 @AppointmentStatus = @AppointmentStatus,
                 @TotalPrice = @TotalPrice,
                 @UserID = @UserID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                        command.Parameters.AddWithValue("@PatientID", PatientID);
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        command.Parameters.AddWithValue("@AppointmentDateTime", AppointmentDateTime);
                        command.Parameters.AddWithValue("@AppointmentStatus", AppointmentStatus);
                        command.Parameters.AddWithValue("@TotalPrice", TotalPrice);
                        command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool Delete(int AppointmentID)
        {
            int RowAffected = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"EXEC SP_DeleteAppointment
                    @AppointmentID = @AppointmentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

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

        public static bool Find(int AppointmentID, out int PatientID, out int DoctorID, out DateTime AppointmentDateTime, out string AppointmentStatus, out decimal TotalPrice, out int UserID)
        {
            bool isFound = false;
            PatientID = 0;
            DoctorID = 0;
            AppointmentDateTime = DateTime.MinValue;
            AppointmentStatus = "";
            TotalPrice = 0;
            UserID = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"EXEC SP_GetAppointmentByID
                    @AppointmentID = @AppointmentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    isFound = true;
                                    PatientID = (int)reader["PatientID"];
                                    DoctorID = (int)reader["DoctorID"];
                                    AppointmentDateTime = (DateTime)reader["AppointmentDateTime"];
                                    AppointmentStatus = reader["AppointmentStatus"].ToString();
                                    TotalPrice = (decimal)reader["TotalPrice"];
                                    UserID = (int)reader["UserID"];
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

        public static DataTable GetAllAppointments()
        {
            DataTable dtAppointments = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"EXEC SP_GetAllAppointments ";

                   using(SqlCommand command = new SqlCommand(query, connection))
            {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtAppointments.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
            }

            return dtAppointments;
        }


    }
}
