using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_DataAccessLayer
{
    public  class clsPrescriptionsData
    {

        public static Nullable<int> AddNewPrescription(SqlParameter[] parameters)
        {

            Nullable<int> PrescriptionID = null;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand Command = new SqlCommand("SP_AddNewPrescription", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddRange(parameters);

                        SqlParameter outputParameter = new SqlParameter("@NewPrescriptionID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputParameter);

                        Command.ExecuteNonQuery();

                        PrescriptionID = (int)Command.Parameters["@NewPrescriptionID"].Value;
                    }
                }
            }

            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
                MessageBox.Show("Error SP_GetPersonByID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return PrescriptionID;

        }

        public static bool UpdatePrescription(SqlParameter[] parameters)
        {
            bool Update = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();

                    using (SqlCommand Command = new SqlCommand("SP_UpdatePrescription", Connection))
                    {

                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        Command.Parameters.AddRange(parameters);

                        int rowAfficted = Command.ExecuteNonQuery();

                        if (rowAfficted > 0)
                            Update = true;
                    }
                }
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
                MessageBox.Show("Error SP_GetPersonByID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Update;
        }

        public static bool DeletePrescription(SqlParameter parameter)
        {
            bool Deleted = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();

                    using (SqlCommand Command = new SqlCommand("SP_DeletePrescription", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(parameter.ParameterName, parameter.Value);

                        int RowAffected = Command.ExecuteNonQuery();

                        if (RowAffected > 0)
                            Deleted = true;

                    }
                }
            }

            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
                MessageBox.Show("Error SP_GetPersonByID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Deleted;
        }

        public static bool FindPrescription(ref SqlParameter[] parameters)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();

                    using (SqlCommand Command = new SqlCommand("SP_GetPrescriptionByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue($"@{parameters[0].ParameterName}", parameters[0].Value);

                        using (SqlDataReader reader = Command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    parameters[i].Value = reader[parameters[i].ParameterName];
                                }

                                isFound = true;
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

        public static bool IsPrescriptionExists( SqlParameter parameter)
        {
            bool Exists = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_IsPrescriptionExists", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(parameter.ParameterName, parameter.Value);

                        SqlParameter returnValue = new SqlParameter
                        {
                            Direction = ParameterDirection.ReturnValue

                        };
                        Command.Parameters.Add(returnValue);

                        Command.ExecuteScalar();
                        int result = (int)returnValue.Value;

                        Exists = (result == 1);
                    }
                }
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
                MessageBox.Show("Error SP_GetPersonByID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Exists;
        }


        public static DataTable GetAllPrescriptions()
        {
            DataTable dtPrescriptions = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();

                    string query = @"exec SP_GetAllPrescription";

                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        using (SqlDataReader reader = Command.ExecuteReader())
                        {

                            if (reader.HasRows)
                                dtPrescriptions.Load(reader);
                            else
                                Console.WriteLine("Thers is no rows");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
                MessageBox.Show("Error SP_GetPersonByID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dtPrescriptions;
        }

    }
}
