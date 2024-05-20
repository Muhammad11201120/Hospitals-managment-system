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
    public  class clsPrescriptions
    {

        //public static Nullable<int> AddNewPrescription(string StoredProcedure, SqlParameter[] parameters)
        //{
        //    Nullable<int> PrescriptionID = null;

        //    using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        //    using (SqlCommand Command = new SqlCommand(StoredProcedure, Connection))
        //    {
        //        Command.CommandType = CommandType.StoredProcedure;

        //        Command.Parameters.AddRange(parameters);

        //        // Output parameter
        //        SqlParameter outputParameter = new SqlParameter($"@NewPrescriptionID", SqlDbType.Int)
        //        {
        //            Direction = ParameterDirection.Output
        //        };
        //        Command.Parameters.Add(outputParameter);

        //        try
        //        {
        //            Connection.Open();

        //            Command.ExecuteScalar();

        //            PrescriptionID = (int)Command.Parameters[$"@NewPrescriptionID"].Value;

        //        }
        //        catch (SqlException ex)
        //        {
        //            // Sql Exception.
        //            clsUtil.StoreEventInEventLogs(SourceName, $"Error {StoredProcedure}: {ex.Message}", clsUtil.enEventType.Error);
        //            MessageBox.Show($"Error {StoredProcedure}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        catch (Exception ex)
        //        {
        //            clsUtil.StoreEventInEventLogs(SourceName, $"Error AddNew {StoredProcedure}: " + ex.Message, clsUtil.enEventType.Error);
        //            MessageBox.Show("Error AddNew {StoredProcedure}: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }

        //    return PrescriptionID;
        //}

        //public static bool FindPrescription(string StoredProcedure, ref SqlParameter[] parameters)
        //{
        //    bool Found = false;

        //    using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        //    using (SqlCommand Command = new SqlCommand(StoredProcedure, Connection))
        //    {
        //        Command.CommandType = CommandType.StoredProcedure;

        //        Command.Parameters.AddWithValue($"@{parameters[0].ParameterName}", parameters[0].Value);

        //        try
        //        {
        //            Connection.Open();

        //            using (SqlDataReader reader = Command.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    for (int i = 0; i < reader.FieldCount; i++)
        //                    {
        //                        parameters[i].Value = reader[parameters[i].ParameterName];
        //                    }

        //                    Found = true;
        //                }
        //            }
        //        }
        //        catch (SqlException ex)
        //        {
        //            // Sql Exception.
        //            clsUtil.StoreEventInEventLogs(SourceName, $"Error {StoredProcedure}: {ex.Message}", clsUtil.enEventType.Error);
        //            MessageBox.Show($"Error {StoredProcedure}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        catch (Exception ex)
        //        {
        //            clsUtil.StoreEventInEventLogs(SourceName, $"Error {StoredProcedure}: {ex.Message}", clsUtil.enEventType.Error);
        //            MessageBox.Show($"Error {StoredProcedure}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }

        //    return Found;
        //}

        //public static bool UpdatePrescription(string StoredProcedure, SqlParameter[] parameters)
        //{
        //    bool Updated = false;

        //    using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        //    using (SqlCommand Command = new SqlCommand(StoredProcedure, Connection))
        //    {
        //        Command.CommandType = CommandType.StoredProcedure;

        //        Command.Parameters.AddRange(parameters);

        //        try
        //        {
        //            Connection.Open();

        //            int rowAfficted = Command.ExecuteNonQuery();

        //            Updated = (rowAfficted > 0);
        //        }
        //        catch (SqlException ex)
        //        {
        //            // Sql Exception.
        //            clsUtil.StoreEventInEventLogs(SourceName, $"Error {StoredProcedure}: {ex.Message}", clsUtil.enEventType.Error);
        //            MessageBox.Show($"Error {StoredProcedure}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        catch (Exception ex)
        //        {
        //            clsUtil.StoreEventInEventLogs(SourceName, $"Error {StoredProcedure}: {ex.Message}", clsUtil.enEventType.Error);
        //            MessageBox.Show($"Error {StoredProcedure}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }

        //    }

        //    return Updated;
        //}

        //public static bool IsPrescriptionExists(string StoredProcedure, SqlParameter parameter)
        //{
        //    bool Exists = false;

        //    using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        //    using (SqlCommand Command = new SqlCommand(StoredProcedure, Connection))
        //    {
        //        Command.CommandType = CommandType.StoredProcedure;

        //        Command.Parameters.AddWithValue(parameter.ParameterName, parameter.Value);

        //        SqlParameter returnValue = new SqlParameter
        //        {
        //            Direction = ParameterDirection.ReturnValue
        //        };
        //        Command.Parameters.Add(returnValue);

        //        try
        //        {
        //            Connection.Open();

        //            Command.ExecuteScalar();
        //            int result = (int)returnValue.Value;

        //            Exists = (result == 1);
        //        }
        //        catch (SqlException ex)
        //        {
        //            // Sql Exception.
        //            clsUtil.StoreEventInEventLogs(SourceName, $"Error {StoredProcedure}: {ex.Message}", clsUtil.enEventType.Error);
        //            MessageBox.Show($"Error {StoredProcedure}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        catch (Exception ex)
        //        {
        //            clsUtil.StoreEventInEventLogs(SourceName, $"Error {StoredProcedure}: {ex.Message}", clsUtil.enEventType.Error);
        //            MessageBox.Show($"Error {StoredProcedure}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }

        //    return Exists;
        //}

        //public static bool DeletePrescription(string StoredProcedure, SqlParameter parameter)
        //{
        //    bool Deleted = false;

        //    using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        //    using (SqlCommand Command = new SqlCommand(StoredProcedure, Connection))
        //    {
        //        Command.CommandType = CommandType.StoredProcedure;

        //        Command.Parameters.AddWithValue(parameter.ParameterName, parameter.Value);


        //        try
        //        {
        //            Connection.Open();

        //            int rowAfficted = Command.ExecuteNonQuery();

        //            Deleted = (rowAfficted > 0);
        //        }
        //        catch (SqlException ex)
        //        {
        //            // Sql Exception.
        //            clsUtil.StoreEventInEventLogs(SourceName, $"Error {StoredProcedure}: {ex.Message}", clsUtil.enEventType.Error);
        //            MessageBox.Show($"Error {StoredProcedure}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        catch (Exception ex)
        //        {
        //            clsUtil.StoreEventInEventLogs(SourceName, $"Error {StoredProcedure}: {ex.Message}", clsUtil.enEventType.Error);
        //            MessageBox.Show($"Error {StoredProcedure}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }

        //    return Deleted;
        //}



    }
}
