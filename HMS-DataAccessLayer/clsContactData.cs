using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace HMS_DataAccessLayer
{
	public class clsContactData
	{
		public static Nullable<int> AddNewContact(SqlParameter[] parameters)
		{
			Nullable<int> ContactID = null;

			using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			using (SqlCommand Command = new SqlCommand("SP_AddNewContact", Connection))
			{
				Command.CommandType = System.Data.CommandType.StoredProcedure;

				Command.Parameters.AddRange(parameters);

				// Output parameter
				SqlParameter outputParameter = new SqlParameter("@NewContactID", SqlDbType.Int)
				{
					Direction = ParameterDirection.Output
				};
				Command.Parameters.Add(outputParameter);

				try
				{
					Connection.Open();

					Command.ExecuteNonQuery();

					ContactID = (int)Command.Parameters["@NewContactID"].Value;

				}
				catch (SqlException ex)
				{
					clsGlobalData.WriteExceptionInLogFile(ex);
					MessageBox.Show($"Error SP_AddNewContact:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					clsGlobalData.WriteExceptionInLogFile(ex);
					MessageBox.Show("Error SP_AddNewContact: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			return ContactID;
		}

		public static bool GetContactByID(ref SqlParameter[] parameters)
		{
			bool Found = false;

			using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			using (SqlCommand Command = new SqlCommand("SP_GetContactByID", Connection))
			{
				Command.CommandType = CommandType.StoredProcedure;

				Command.Parameters.AddWithValue($"@{parameters[0].ParameterName}", parameters[0].Value);

				using (SqlDataReader reader = Command.ExecuteReader())
				{
					if (reader.Read())
					{
						try
						{
							Connection.Open();

							for (int i = 0; i < reader.FieldCount; i++)
							{
								parameters[i].Value = reader[parameters[i].ParameterName];
							}

							Found = true;
						}
						catch (SqlException ex)
						{
							clsGlobalData.WriteExceptionInLogFile(ex);
							MessageBox.Show($"Error SP_GetContactByID:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						catch (Exception ex)
						{
							clsGlobalData.WriteExceptionInLogFile(ex);
							MessageBox.Show("Error SP_GetContactByID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}

			}

			return Found;
		}

		public static bool UpdateContact(SqlParameter[] parameters)
		{
			bool Updated = false;

			using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			using (SqlCommand Command = new SqlCommand("SP_UpdateContact", Connection))
			{
				Command.CommandType = CommandType.StoredProcedure;

				Command.Parameters.AddRange(parameters);

				try
				{
					Connection.Open();

					int rowAfficted = Command.ExecuteNonQuery();

					if (rowAfficted > 0)
						Updated = true;
				}
				catch (SqlException ex)
				{
					clsGlobalData.WriteExceptionInLogFile(ex);
					MessageBox.Show($"Error SP_UpdateContact:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					clsGlobalData.WriteExceptionInLogFile(ex);
					MessageBox.Show("Error SP_UpdateContact: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}

			return Updated;
		}

		public static bool IsContactExist(SqlParameter parameter)
		{
			bool Exists = false;

			using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			using (SqlCommand Command = new SqlCommand("SP_IsContactExists", Connection))
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
				catch (SqlException ex)
				{
					clsGlobalData.WriteExceptionInLogFile(ex);
					MessageBox.Show($"Error SP_IsContactExists:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					clsGlobalData.WriteExceptionInLogFile(ex);
					MessageBox.Show($"Error SP_IsContactExists:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			return Exists;
		}
		
		public static bool DeleteContact(SqlParameter parameter)
		{
			bool Deleted = false;

			using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			using (SqlCommand Command = new SqlCommand("SP_DeleteContact", Connection))
			{
				Command.Parameters.AddWithValue(parameter.ParameterName, parameter.Value);

				try
				{
					Connection.Open();

					int rowafficted = Command.ExecuteNonQuery();

					Deleted = (rowafficted > 0);
				}
				catch (SqlException ex)
				{
					clsGlobalData.WriteExceptionInLogFile(ex);
					MessageBox.Show($"Error SP_DeleteContact:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					clsGlobalData.WriteExceptionInLogFile(ex);
					MessageBox.Show($"Error SP_DeleteContact:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			return Deleted;
		}
	}
}
