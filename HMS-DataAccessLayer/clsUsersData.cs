using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HMS_DataAccessLayer
{
    public class clsUsersData
    {
        //public static int AddNew(int EmployeeID, string UserName,
        //    string Password, bool IsActive)
        //{
        //    int UserID = -1;

        //    try
        //    {

        //        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        //        {
        //            connection.Open();

        //            string query = @"exec SP_AddNewUser
        //                   @EmployeeID = @employeeID ,
        //                   @UserName   = @userName   ,
        //                   @Password   = @password   ,
        //                   @IsActive   = @isActive; ";

        //            using (SqlCommand Command = new SqlCommand(query, connection))
        //            {

        //                Command.Parameters.AddWithValue("@employeeID", EmployeeID);
        //                Command.Parameters.AddWithValue("@userName", UserName);
        //                Command.Parameters.AddWithValue("@password", Password);
        //                Command.Parameters.AddWithValue("@isActive", IsActive);

        //                object result = Command.ExecuteScalar();

        //                if (result != null && int.TryParse(result.ToString(), out int insertedID))
        //                {
        //                    UserID = insertedID;
        //                }

        //            }
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        clsGlobalData.WriteExceptionInLogFile(ex);
        //    }

        //    return UserID;

        //}

        //public static bool Update(int UserID , int EmployeeID, string UserName,
        //    string Password, bool IsActive)
        //{
        //    int RowAffected = -1;

        //    try
        //    {
        //        using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        //        {
        //            Connection.Open();

        //            string query = @"exec SP_UpdatePerson
        //                           @UserID     = @userID  ,
        //                           @EmployeeID = @employeeID  ,
        //                           @UserName   = @userName ,  
        //                           @Password   = @password ,
        //                           @IsActive   = @isActive;";
        //            using (SqlCommand Command = new SqlCommand(query, Connection))
        //            {

        //                Command.Parameters.AddWithValue("@userID", UserID);
        //                Command.Parameters.AddWithValue("@employeeID", EmployeeID);
        //                Command.Parameters.AddWithValue("@userName", UserName);
        //                Command.Parameters.AddWithValue("@password", Password);
        //                Command.Parameters.AddWithValue("@isActive", IsActive);



        //                RowAffected = Command.ExecuteNonQuery();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        clsGlobalData.WriteExceptionInLogFile(ex);
        //    }

        //    return (RowAffected > 0);
        //}

        //public static bool Delete(int UserID)
        //{
        //    int RowAffected = -1;

        //    try
        //    {
        //        using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        //        {
        //            Connection.Open();

        //            string query = @"EXEC  SP_DeleteUser
		      //                      @UserID = @userID";
        //            using (SqlCommand Command = new SqlCommand(query, Connection))
        //            {
        //                Command.Parameters.AddWithValue("@userID", UserID);

        //                RowAffected = Command.ExecuteNonQuery();
        //            }
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        clsGlobalData.WriteExceptionInLogFile(ex);
        //    }

        //    return (RowAffected > 0);
        //}

        //public static bool Find(int UserID,ref int EmployeeID,ref string UserName,
        //    ref string Password,ref bool IsActive)
        //{
        //    bool isFound = false;

        //    try
        //    {
        //        using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        //        {

        //            string query = @"EXEC SP_GetUserByID
		      //                     @UserID = @userID";

        //            using (SqlCommand Command = new SqlCommand(query, Connection))
        //            {

        //                Command.Parameters.AddWithValue("@userID", UserID);

        //                Connection.Open();

        //                using (SqlDataReader reader = Command.ExecuteReader())
        //                {

        //                    if (reader.HasRows)
        //                    {
        //                        while (reader.Read())
        //                        {
                                   
        //                            isFound = true;
        //                            EmployeeID = (int)reader["EmployeeID"];
        //                            Password = (string)reader["Password"];
        //                            IsActive = (bool)reader["IsActive"];
        //                            UserName = (string)reader["UserName"];
        //                        }
        //                    }
        //                    else
        //                    {
        //                        isFound = false;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        clsGlobalData.WriteExceptionInLogFile(ex);
        //    }
        //    return isFound;
        //}

        public static DataTable GetAllUsers()
        {
            DataTable dtUsers = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();

                    string query = @"exec SP_GetAllUsers";

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
            }
            return dtUsers;
        }

        public static Nullable <int> AddNewUser(SqlParameter[] parameters)
        {

            Nullable<int> UserID = null;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand Command = new SqlCommand("SP_AddNewUser", connection))
                    {
                        Command.CommandType  = CommandType.StoredProcedure;

                        Command.Parameters.AddRange(parameters);

                        SqlParameter outputParameter = new SqlParameter("@NewUserID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputParameter);

                        Command.ExecuteNonQuery();

                        UserID = (int)Command.Parameters["@NewUserID"].Value;
                    }
                }
            }

            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
            }

            return UserID;

        }

        public static bool UpdateUser(SqlParameter[] parameters)
        {
            bool Update = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();

                    using (SqlCommand Command = new SqlCommand("SP_UpdateUser", Connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;

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
            }

            return Update;
        }

        public static bool DeleteUser(SqlParameter parameter)
        {
            bool Deleted = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();

                    using (SqlCommand Command = new SqlCommand("SP_DeleteUser", Connection))
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
            }

            return Deleted;
        }

        public static bool FindUser(ref SqlParameter[] parameters)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open ();

                    using (SqlCommand Command = new SqlCommand("SP_GetUserByID", Connection))
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


    }
}
