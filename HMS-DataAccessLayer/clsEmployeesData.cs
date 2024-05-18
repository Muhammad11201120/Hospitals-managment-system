using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccessLayer
{
    public class clsEmployeesData
    {
        public static int AddNew(int PersonID, decimal Salary)
        {
            int EmployeeID = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"exec SP_AddNewEmployee
                           @PersonID = @personID ,
                           @Salary   = @salary     ; ";

                    using (SqlCommand Command = new SqlCommand(query, connection))
                    {

                        Command.Parameters.AddWithValue("@salary", Salary);
                        Command.Parameters.AddWithValue("@personID", PersonID);

                        object result = Command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            EmployeeID = insertedID;
                        }

                    }
                }
            }

            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
            }

            return EmployeeID;

        }

        public static bool Update(int EmployeeID,int PersonID, decimal Salary)
        {
            int RowAffected = -1;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();

                    string query = @"exec SP_UpdateEmpolyee
                                   @PersonID     = @personID  ,
                                   @EmployeeID   = @employeeID  ,
                                   @Salary       = @salary;";
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {

                        Command.Parameters.AddWithValue("@personID", PersonID);
                        Command.Parameters.AddWithValue("@employeeID", EmployeeID);
                        Command.Parameters.AddWithValue("@salary", Salary);

                        RowAffected = Command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
            }

            return (RowAffected > 0);
        }

        public static bool Delete(int EmployeeID)
        {
            int RowAffected = -1;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();

                    string query = @"EXEC  SP_DeleteEmpolyee
		                            @EmployeeID = @employeeID";
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@employeeID", EmployeeID);

                        RowAffected = Command.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
            }

            return (RowAffected > 0);
        }

        public static bool Find(int EmployeeID,ref int PersonID,ref decimal Salary)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    string query = @"EXEC SP_GetEmpolyeeByID
		                           @EmployeeID = @employeeID";

                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {

                        Command.Parameters.AddWithValue("@employeeID", EmployeeID);

                        Connection.Open();

                        using (SqlDataReader reader = Command.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {

                                    isFound = true;
                                    Salary = (decimal)reader["Salary"];
                                    PersonID = (int)reader["PersonID"];
                                }
                            }
                            else
                            {
                                isFound = false;
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

        public static DataTable GetAllEmpolyee()
        {
            DataTable dtEmployees = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();

                    string query = @"exec SP_GetAllEmpolyee";

                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        using (SqlDataReader reader = Command.ExecuteReader())
                        {

                            if (reader.HasRows)
                                dtEmployees.Load(reader);
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
            return dtEmployees;
        }

    }
}
