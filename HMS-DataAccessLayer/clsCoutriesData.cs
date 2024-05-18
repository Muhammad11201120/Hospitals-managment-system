using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace HMS_DataAccessLayer
{
	public class clsCoutriesData
	{
		public static bool GetCountry(ref SqlParameter[] parameters)
		{
			bool Found = false;

			using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			using (SqlCommand Command = new SqlCommand("SP_GetCountry", Connection))
			{
				Command.CommandType = CommandType.StoredProcedure;

				Command.Parameters.AddWithValue($"@{parameters[0].ParameterName}", parameters[0].Value);

				Connection.Open();

				using (SqlDataReader reader = Command.ExecuteReader())
				{
					if (reader.Read())
					{
						try
						{
							
							for (int i = 0; i < reader.FieldCount; i++)
							{
								parameters[i].Value = reader[parameters[i].ParameterName];
							}

							Found = true;
						}
						catch (SqlException ex)
						{
							clsGlobalData.WriteExceptionInLogFile(ex);
							MessageBox.Show($"Error SP_GetCountry:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						catch (Exception ex)
						{
							clsGlobalData.WriteExceptionInLogFile(ex);
							MessageBox.Show("Error SP_GetCountry: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}

			}

			return Found;
		}

		public static DataTable GetAllCountries()
		{
			DataTable dt = new DataTable();

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			using (SqlCommand command = new SqlCommand("SP_GetAllCountries", connection))
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
				catch (SqlException ex)
				{
					// Sql Exception.
					clsGlobalData.WriteExceptionInLogFile(ex);
					MessageBox.Show($"Error SP_GetAllCountries : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					clsGlobalData.WriteExceptionInLogFile(ex);
					MessageBox.Show($"Error SP_GetAllCountries : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}


			return dt;
		}

	}
}
