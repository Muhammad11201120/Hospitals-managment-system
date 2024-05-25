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
    public class clsDocotrsData { 
    public static Nullable<int> AddNewDoctor( SqlParameter[] parameters)
    {
        Nullable<int> DoctorID = null;

        using (SqlConnection Connection = new SqlConnection(    clsDataAccessSettings.ConnectionString))
        using (SqlCommand Command = new SqlCommand("SP_AddNewDoctor", Connection))
        {
            Command.CommandType = CommandType.StoredProcedure;

            Command.Parameters.AddRange(parameters);

            // Output parameter
            SqlParameter outputParameter = new SqlParameter($"@NewDoctorID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            Command.Parameters.Add(outputParameter);

            try
            {
                Connection.Open();

                Command.ExecuteScalar();

                DoctorID = (int)Command.Parameters[$"@NewDoctorID"].Value;

            }
            catch (Exception ex)
            {
                    clsGlobalData.WriteExceptionInLogFile(ex);
                    MessageBox.Show("Error AddNew : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        return DoctorID;
    }
       
        public static bool Find( ref SqlParameter[] parameters)
    {
        bool Found = false;

        using (SqlConnection Connection = new SqlConnection(    clsDataAccessSettings.ConnectionString))
        using (SqlCommand Command = new SqlCommand("SP_GetDoctorByID", Connection))
        {
            Command.CommandType = CommandType.StoredProcedure;

            Command.Parameters.AddWithValue($"@{parameters[0].ParameterName}", parameters[0].Value);

            try
            {
                Connection.Open();

                using (SqlDataReader reader = Command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            parameters[i].Value = reader[parameters[i].ParameterName];
                        }

                        Found = true;
                    }
                }
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
                MessageBox.Show($"Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        return Found;
    }

    public static bool UpdateDoctor( SqlParameter[] parameters)
    {
        bool Updated = false;

        using (SqlConnection Connection = new SqlConnection(    clsDataAccessSettings.ConnectionString))
        using (SqlCommand Command = new SqlCommand("SP_UpdateDoctor", Connection))
        {
            Command.CommandType = CommandType.StoredProcedure;

            Command.Parameters.AddRange(parameters);

            try
            {
                Connection.Open();

                int rowAfficted = Command.ExecuteNonQuery();

                Updated = (rowAfficted > 0);
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
                MessageBox.Show($"Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        return Updated;
    }

    public static bool IsDoctorExists( SqlParameter parameter)
    {
        bool Exists = false;

        using (SqlConnection Connection = new SqlConnection(    clsDataAccessSettings.ConnectionString))
        using (SqlCommand Command = new SqlCommand("SP_IsDoctorExist", Connection))
        {
            Command.CommandType = CommandType.StoredProcedure;

            Command.Parameters.AddWithValue(parameter.ParameterName, parameter.Value);

            SqlParameter returnValue = new SqlParameter
            {
                Direction = ParameterDirection.ReturnValue
            };
            Command.Parameters.Add(returnValue);

            try
            {
                Connection.Open();

                Command.ExecuteScalar();
                int result = (int)returnValue.Value;

                Exists = (result == 1);
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
                MessageBox.Show($"Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        return Exists;
    }

    public static bool DeleteDoctor( SqlParameter parameter)
    {
        bool Deleted = false;

        using (SqlConnection Connection = new SqlConnection(    clsDataAccessSettings.ConnectionString))
        using (SqlCommand Command = new SqlCommand("SP_DeleteDoctor", Connection))
        {
            Command.CommandType = CommandType.StoredProcedure;

            Command.Parameters.AddWithValue(parameter.ParameterName, parameter.Value);


            try
            {
                Connection.Open();

                int rowAfficted = Command.ExecuteNonQuery();

                Deleted = (rowAfficted > 0);
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
                MessageBox.Show($"Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        return Deleted;
    }

        public static DataTable GetAllDoctors()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_GetAllDoctors", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                    }

                }
                catch (Exception ex)
                {
                    clsGlobalData.WriteExceptionInLogFile(ex);
                    MessageBox.Show($"Error  : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            return dt;
        }

    }
}


