using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccessLayer
{
    public  class clsPaymentsData
    {
        public static int AddNew(DateTime PaymentDate, string PaymentMethod, decimal AmountPaid, int MedicalRecordID, string AdditionalNotes)
        {
            int PaymentID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"EXEC SP_AddNewPayment
                 @PaymentDate = @PaymentDate,
                 @PaymentMethod = @PaymentMethod,
                 @AmountPaid = @AmountPaid,
                 @MedicalRecordID = @MedicalRecordID,
                 @AdditionalNotes = @AdditionalNotes;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                        command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                        command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
                        command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
                        command.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            PaymentID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
                // Handle or log the exception here
            }

            return PaymentID;
        }

        public static bool Update(int PaymentID, DateTime PaymentDate, string PaymentMethod, decimal AmountPaid, int MedicalRecordID, string AdditionalNotes)
        {
            int RowAffected = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"EXEC SP_UpdatePayment
                 @PaymentID = @PaymentID,
                 @PaymentDate = @PaymentDate,
                 @PaymentMethod = @PaymentMethod,
                 @AmountPaid = @AmountPaid,
                 @MedicalRecordID = @MedicalRecordID,
                 @AdditionalNotes = @AdditionalNotes;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", PaymentID);
                        command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                        command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                        command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
                        command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
                        command.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);

                        RowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
                // Handle or log the exception here
            }

            return (RowAffected > 0);
        }

        public static bool Delete(int PaymentID)
        {
            int RowAffected = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"EXEC SP_DeletePayment
                    @PaymentID = @PaymentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", PaymentID);

                        RowAffected = command.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
            }

            return (RowAffected > 0);
        }

        public static bool IsPaymentExist(int PaymentID)
        {
            bool isExist = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"EXEC SP_IsPaymentExist 
                 @PaymentID = @PaymentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", PaymentID);

                        object result = command.ExecuteScalar();

                        if (result != null && (int)result == 1)
                        {
                            isExist = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsGlobalData.WriteExceptionInLogFile(ex);
                // Handle or log the exception here
            }

            return isExist;
        }

    }
}
