using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace HMS_DataAccessLayer
{
	public class clsMedicalRecordsData
	{
		public static Nullable<int> AddNewMedicalRecord(SqlParameter[] parameters)
		{
			Nullable<int> MedicalRecordID = null;

			using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			using (SqlCommand Command = new SqlCommand("SP_AddNewMedicalRecord", Connection))
			{
				Command.CommandType = CommandType.StoredProcedure;

				Command.Parameters.AddRange(parameters);

				// Output parameter
				SqlParameter outputParameter = new SqlParameter($"@NewMedicalRecordID", SqlDbType.Int)
				{
					Direction = ParameterDirection.Output
				};
				Command.Parameters.Add(outputParameter);

				try
				{
					Connection.Open();

					Command.ExecuteScalar();

					MedicalRecordID = (int)Command.Parameters[$"@NewMedicalRecordID"].Value;

				}
				catch (Exception ex)
				{
					clsGlobalData.WriteExceptionInLogFile(ex);
					MessageBox.Show("Error SP_AddNewMedicalRecord: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			return MedicalRecordID;
		}

		public static bool GetMedicalRecordByID(ref SqlParameter[] parameters)
		{
			bool Found = false;

			using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			using (SqlCommand Command = new SqlCommand("SP_GetMedicalRecordByID", Connection))
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
					MessageBox.Show($"Error SP_GetMedicalRecordByID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			return Found;
		}

		public static bool UpdateMedicalRecord(SqlParameter[] parameters)
		{
			bool Updated = false;

			using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			using (SqlCommand Command = new SqlCommand("SP_UpdateMedicalRecord", Connection))
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
					MessageBox.Show($"Error SP_UpdateMedicalRecord: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}

			return Updated;
		}

		public static bool IsMedicalRecordExists(SqlParameter parameter)
		{
			bool Exists = false;

			using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			using (SqlCommand Command = new SqlCommand("SP_IsMedicalRecordExists", Connection))
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
					MessageBox.Show($"Error SP_IsMedicalRecordExists: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			return Exists;
		}

		public static bool DeleteMedicalRecord(SqlParameter parameter)
		{
			bool Deleted = false;

			using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			using (SqlCommand Command = new SqlCommand("SP_DeleteMedicalRecord", Connection))
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
					MessageBox.Show($"Error SP_DeleteMedicalRecord: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			return Deleted;
		}

	}
}
