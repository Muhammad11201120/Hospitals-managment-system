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
    public class HospitalInfoData
    {
        public static Nullable<int> AddNewHospitalInfo(SqlParameter[] parameters)
        {
            int? ID = null;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand Command = new SqlCommand("SP_AddNewHospital", Connection))
                {
                    Connection.Open();

                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddRange(parameters);

                    SqlParameter outputParameter = new SqlParameter("@NewHospitalID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    Command.Parameters.Add(outputParameter);

                    Command.ExecuteNonQuery();

                    ID = (int)Command.Parameters["@NewHospitalID"].Value;
                }
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
               
                MessageBox.Show("Error  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ID;
        }

        public static bool FindHospitalInfoByID(ref SqlParameter[] parameters)
        {
            bool Found = false;

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand("SP_GetHospitalByID", Connection))
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

        public static bool FindHospitalInfoByName(ref SqlParameter[] parameters)
        {
            bool Found = false;

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand("SP_GetHospitalByName", Connection))
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

        public static bool UpdateHospitalInfo(SqlParameter[] parameters)
        {
            bool Updated = false;

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand("SP_UpdateHospital", Connection))
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

        public static DataTable GetAllHospital()
        {
            DataTable dtUsers = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();

                    string query = @"exec SP_GetAllHospitals";

                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        using (SqlDataReader reader = Command.ExecuteReader())
                        {

                            if (reader.HasRows)
                                dtUsers.Load(reader);
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
            return dtUsers;
        }

        public static bool IsHospitalInfoExists(SqlParameter parameter)
        {
            bool Exists = false;

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand("SP_IsHospitalExist", Connection))
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

        public static bool DeleteHospitalInfo(SqlParameter parameter)
        {
            bool Deleted = false;

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand("SP_DeleteHospital", Connection))
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

    }
}


