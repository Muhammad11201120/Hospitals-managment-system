using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace HMS_DataAccessLayer
{
	public class clsPeopleData
	{
		public static Nullable<int> AddNewPerson(SqlParameter[] parameters)
		{
			Nullable<int> PersonID = null;

			try
			{
				using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
				using (SqlCommand Command = new SqlCommand("SP_AddNewPerson", Connection))
				{
					Command.CommandType = System.Data.CommandType.StoredProcedure;

					Command.Parameters.AddRange(parameters);

					// Output parameter
					SqlParameter outputParameter = new SqlParameter("@NewPersonID", SqlDbType.Int)
					{
						Direction = ParameterDirection.Output
					};
					Command.Parameters.Add(outputParameter);


					Connection.Open();

					Command.ExecuteNonQuery();

					PersonID = (int)Command.Parameters["@NewPersonID"].Value;
				}
			}
			catch (Exception ex)
			{
				clsGlobalData.WriteExceptionInLogFile(ex);
				MessageBox.Show("Error SP_AddNewPerson: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return PersonID;
		}

		public static bool GetPersonByID(ref SqlParameter[] parameters)
		{
			bool Found = false;

			using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			using (SqlCommand Command = new SqlCommand("SP_GetPersonByID", Connection))
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
							{
								for (int i = 0; i < reader.FieldCount; i++)
								{
									parameters[i].Value = reader[parameters[i].ParameterName];
								}

								Found = true;
							}
						}
					}
				}
				catch (Exception ex)
				{
					clsGlobalData.WriteExceptionInLogFile(ex);
					MessageBox.Show("Error SP_GetPersonByID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}

			return Found;
		}

		public static bool UpdatePerson(SqlParameter[] parameters)
		{
			bool Updated = false;

			using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			using (SqlCommand Command = new SqlCommand("SP_UpdatePerson", Connection))
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
				catch (Exception ex)
				{
					clsGlobalData.WriteExceptionInLogFile(ex);
					MessageBox.Show("Error SP_UpdatePerson: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}

			return Updated;
		}

		public static bool IsPersonExist(SqlParameter parameter)
		{
			bool Exists = false;

			using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			using (SqlCommand Command = new SqlCommand("SP_IsPersonExists", Connection))
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
					MessageBox.Show($"Error SP_IsPersonExists:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			return Exists;
		}

        public static bool IsPersonExistByNationalNO(SqlParameter parameter)
        {
            bool Exists = false;

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand("SP_IsPeopleExistsByNationalNO", Connection))
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
                    MessageBox.Show($"Error SP_IsPeopleExistsByNationalNO:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return Exists;
        }

        public static bool DeletePerson(SqlParameter parameter)
		{
			bool Deleted = false;

			using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			using (SqlCommand Command = new SqlCommand("SP_DeletePerson", Connection))
			{
				Command.CommandType = CommandType.StoredProcedure;

				Command.Parameters.AddWithValue(parameter.ParameterName, parameter.Value);

				try
				{
					Connection.Open();

					int rowafficted = Command.ExecuteNonQuery();

					Deleted = (rowafficted > 0);
				}
				catch (Exception ex)
				{
					clsGlobalData.WriteExceptionInLogFile(ex);
					MessageBox.Show($"Error SP_DeletePerson:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			return Deleted;
		}

		public static DataTable GetAllPeople()
		{
			DataTable dt = new DataTable();

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			using (SqlCommand command = new SqlCommand("SP_GetAllPeople", connection))
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
					MessageBox.Show($"Error SP_GetAllPeople : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}


			return dt;
		}

	}
}
