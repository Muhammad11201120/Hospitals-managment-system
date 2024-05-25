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
    public class clsSpecialityData
    {

        public static Nullable<int> AddNewSpecialtie( SqlParameter[] parameters)
        {
            Nullable<int> SpecialityID = null;

            using (SqlConnection Connection = new SqlConnection(    clsDataAccessSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand( "SP_AddNewSpeciality",Connection))
            {
                Command.CommandType = CommandType.StoredProcedure;

                Command.Parameters.AddRange(parameters);

                // Output parameter
                SqlParameter outputParameter = new SqlParameter($"@NewSpecialityID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                Command.Parameters.Add(outputParameter);

                try
                {
                    Connection.Open();

                    Command.ExecuteScalar();

                    SpecialityID = (int)Command.Parameters[$"@NewSpecialityID"].Value;

                }
                catch (Exception ex)
                {
                    clsGlobalData.WriteExceptionInLogFile(ex);
                    MessageBox.Show("Error AddNew : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return SpecialityID;
        }

        public static bool FindSpeciality( ref SqlParameter[] parameters)
        {
            bool Found = false;

            using (SqlConnection Connection = new SqlConnection(    clsDataAccessSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand("SP_GetSpecialityByID", Connection))
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

        public static bool UpdateSpeciality( SqlParameter[] parameters)
        {
            bool Updated = false;

            using (SqlConnection Connection = new SqlConnection(    clsDataAccessSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand("SP_UpdateSpeciality", Connection))
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

        public static bool IsSpecialityExists(SqlParameter parameter)
        {
            bool Exists = false;

            using (SqlConnection Connection = new SqlConnection(    clsDataAccessSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand("SP_IsSpecialityExist", Connection))
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

        public static bool DeleteSpeciality( SqlParameter parameter)
        {
            bool Deleted = false;

            using (SqlConnection Connection = new SqlConnection(    clsDataAccessSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand("SP_DeleteSpeciality", Connection))
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
