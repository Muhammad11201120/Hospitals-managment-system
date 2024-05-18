using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccessLayer
{
    public class clsPatientsData
    {
        public static int AddNew(int PersonID)
        {
            int PatientID = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"exec SP_AddNewPatient
                           @PersonID = @personID  ; ";

                    using (SqlCommand Command = new SqlCommand(query, connection))
                    {

                        Command.Parameters.AddWithValue("@personID", PersonID);

                        object result = Command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            PatientID = insertedID;
                        }

                    }
                }
            }

            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
            }

            return PatientID;

        }

        public static bool Update(int PatientID ,int PersonID)
        {
            int RowAffected = -1;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();

                    string query = @"exec SP_UpdatePatient
                                   @PersonID = @personID  ,
                                   @PatientID   = @patientID;";
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {

                        Command.Parameters.AddWithValue("@personID", PersonID);
                        Command.Parameters.AddWithValue("@patientID", PatientID);

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

        public static bool Delete(int PatientID)
        {
            int RowAffected = -1;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();

                    string query = @"EXEC  SP_DeletePatient
		                            @PatientID = @patientID";
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@patientID", PatientID);

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

        public static bool Find(int PatientID, ref int PersonID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    string query = @"EXEC SP_GetPatientByID
		                           @PatientID = @patientID";

                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {

                        Command.Parameters.AddWithValue("@patientID", PatientID);

                        Connection.Open();

                        using (SqlDataReader reader = Command.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {

                                    isFound = true;
                                    PersonID = (int)reader["PersonID"];
                                }
                            }
                            else
                            {
                                isFound = false;
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

        public static DataTable GetAllPatients()
        {
            DataTable dtPatients = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();

                    string query = @"exec SP_GetAllPatients";

                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        using (SqlDataReader reader = Command.ExecuteReader())
                        {

                            if (reader.HasRows)
                                dtPatients.Load(reader);
                            else
                                Console.WriteLine("Thers is no rows");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
            }
            return dtPatients;
        }

    }
}
