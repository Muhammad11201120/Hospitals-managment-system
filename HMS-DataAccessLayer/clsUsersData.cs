using System;
using System.Data.SqlClient;

namespace HMS_DataAccessLayer
{
    public class clsUsersData
    {
        public static int AddNewUser(int EmployeeID, string UserName,
            string Password, bool IsActive)
        {
            int UserID = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"exec SP_AddNewUser
                           @EmployeeID = @employeeID ,
                           @UserName   = @userName   ,
                           @Password   = @password   ,
                           @IsActive   = @isActive; ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@employeeID", EmployeeID);
                        command.Parameters.AddWithValue("@userName", UserName);
                        command.Parameters.AddWithValue("@password", Password);
                        command.Parameters.AddWithValue("@isActive", IsActive);



                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            UserID = insertedID;
                        }

                    }
                }
            }

            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
            }

            return UserID;

        }


    }
}
