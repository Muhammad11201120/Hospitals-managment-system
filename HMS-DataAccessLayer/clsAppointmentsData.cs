using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace HMS_DataAccessLayer
{
    public class clsAppointmentsData
    {
        public static Nullable<int> AddNewAppointment( SqlParameter[] parameters )
        {
            Nullable<int> AppointmentID = null;
            try
            {
                using ( SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
                {
                    using ( SqlCommand Command = new SqlCommand( "SP_AddNewAppointment", Connection ) )
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddRange( parameters );

                        // Output parameter
                        SqlParameter outputParameter = new SqlParameter( $"@NewAppointmentID", SqlDbType.Int )
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add( outputParameter );


                        Connection.Open();

                        Command.ExecuteScalar();

                        AppointmentID = ( int ) Command.Parameters[ $"@NewAppointmentID" ].Value;

                    }
                }
            }
            catch ( Exception ex )
            {
                clsGlobalData.WriteExceptionInLogFile( ex );
                MessageBox.Show( ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            return AppointmentID;
        }
        public static bool FindAppointment( ref SqlParameter[] parameters )
        {
            bool Found = false;
            try
            {
                using ( SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
                {
                    using ( SqlCommand Command = new SqlCommand( "SP_GetAppointmentByID", Connection ) )
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue( $"@{parameters[ 0 ].ParameterName}", parameters[ 0 ].Value );


                        Connection.Open();

                        using ( SqlDataReader reader = Command.ExecuteReader() )
                        {
                            if ( reader.Read() )
                            {
                                for ( int i = 0; i < reader.FieldCount; i++ )
                                {
                                    parameters[ i ].Value = reader[ parameters[ i ].ParameterName ];
                                }

                                Found = true;
                            }
                        }
                    }
                }
            }
            catch ( Exception ex )
            {
                clsGlobalData.WriteExceptionInLogFile( ex );
                MessageBox.Show( $" {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            return Found;
        }
        public static bool UpdateAppointment( SqlParameter[] parameters )
        {
            bool Updated = false;

            try
            {
                using ( SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
                {
                    using ( SqlCommand Command = new SqlCommand( "SP_UpdateAppointment", Connection ) )
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddRange( parameters );

                        Connection.Open();

                        int rowAfficted = Command.ExecuteNonQuery();

                        Updated = ( rowAfficted > 0 );
                    }
                }
            }
            catch ( Exception ex )
            {
                clsGlobalData.WriteExceptionInLogFile( ex );
                MessageBox.Show( $" {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            return Updated;
        }
        public static bool IsAppointmentExists( SqlParameter parameter )
        {
            bool Exists = false;
            try
            {
                using ( SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
                {
                    using ( SqlCommand Command = new SqlCommand( "SP_IsAppointmentExist", Connection ) )
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue( parameter.ParameterName, parameter.Value );

                        SqlParameter returnValue = new SqlParameter
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add( returnValue );

                        Connection.Open();

                        Command.ExecuteScalar();
                        int result = ( int ) returnValue.Value;

                        Exists = ( result == 1 );
                    }
                }
            }
            catch ( Exception ex )
            {
                clsGlobalData.WriteExceptionInLogFile( ex );
                MessageBox.Show( $"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            return Exists;
        }
        public static bool IsAppointmentExistByPatientIDAndDate( SqlParameter[] parameters )
        {
            bool Exists = false;
            try
            {
                using ( SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
                {
                    using ( SqlCommand Command = new SqlCommand( "SP_IsAppointmentExistByPatientIDAndDate ", Connection ) )
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddRange( parameters );

                        SqlParameter returnValue = new SqlParameter
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add( returnValue );

                        Connection.Open();

                        Command.ExecuteScalar();
                        int result = ( int ) returnValue.Value;

                        Exists = ( result == 1 );
                    }
                }
            }
            catch ( Exception ex )
            {
                clsGlobalData.WriteExceptionInLogFile( ex );
                MessageBox.Show( $"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            return Exists;
        }
        public static bool IsAppointmentExistByDoctorIDAndDate( SqlParameter[] parameters )
        {
            bool Exists = false;
            try
            {
                using ( SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
                {
                    using ( SqlCommand Command = new SqlCommand( "SP_IsAppointmentExistByDoctorIDAndDate ", Connection ) )
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddRange( parameters );

                        SqlParameter returnValue = new SqlParameter
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add( returnValue );

                        Connection.Open();

                        Command.ExecuteScalar();
                        int result = ( int ) returnValue.Value;

                        Exists = ( result == 1 );
                    }
                }
            }
            catch ( Exception ex )
            {
                clsGlobalData.WriteExceptionInLogFile( ex );
                MessageBox.Show( $"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            return Exists;
        }
        public static bool DeleteAppointment( SqlParameter parameter )
        {
            bool Deleted = false;
            try
            {
                using ( SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
                {
                    using ( SqlCommand Command = new SqlCommand( "SP_DeleteAppointment", Connection ) )
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue( parameter.ParameterName, parameter.Value );

                        Connection.Open();

                        int rowAfficted = Command.ExecuteNonQuery();

                        Deleted = ( rowAfficted > 0 );
                    }
                }
            }
            catch ( Exception ex )
            {
                clsGlobalData.WriteExceptionInLogFile( ex );
                MessageBox.Show( $"Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }

            return Deleted;
        }
        public static DataTable GetAllAppointmentsHourByDoctorAndDate( SqlParameter[] parameters )
        {
            DataTable dtUsers = new DataTable();
            try
            {

                using ( SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
                {
                    Connection.Open();
                    using ( SqlCommand Command = new SqlCommand( "SP_GetAllAppointmentsHourByDoctorAndDate", Connection ) )
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddRange( parameters );

                        using ( SqlDataReader reader = Command.ExecuteReader() )
                        {

                            if ( reader.HasRows )
                                dtUsers.Load( reader );
                            else
                                Console.WriteLine( "Thers is no rows" );
                        }
                    }
                }
            }
            catch ( Exception ex )
            {
                clsGlobalData.WriteExceptionInLogFile( ex );
                MessageBox.Show( "Error SP_GetPersonByID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            return dtUsers;
        }
        public static DataTable GetAllAppointmentsDateByDoctorAndDate( SqlParameter[] parameters )
        {
            DataTable dtUsers = new DataTable();
            try
            {

                using ( SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
                {
                    Connection.Open();
                    using ( SqlCommand Command = new SqlCommand( "SP_GetAllAppointmentsDateByDoctorAndDate", Connection ) )
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddRange( parameters );

                        using ( SqlDataReader reader = Command.ExecuteReader() )
                        {

                            if ( reader.HasRows )
                                dtUsers.Load( reader );
                            else
                                Console.WriteLine( "Thers is no rows" );
                        }
                    }
                }
            }
            catch ( Exception ex )
            {
                clsGlobalData.WriteExceptionInLogFile( ex );
                MessageBox.Show( "Error SP_GetPersonByID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            return dtUsers;
        }
        public static bool SetCompleteAppointmentWithPrescription( SqlParameter[] parameters )
        {
            bool updated = false;
            try
            {
                using ( SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
                {
                    using ( SqlCommand Command = new SqlCommand( "SP_CompleteAppointmentWithPrescription", Connection ) )
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddRange( parameters );

                        Connection.Open();

                        int rowAffected = Command.ExecuteNonQuery();

                        updated = ( rowAffected > 0 );
                    }
                }
            }
            catch ( Exception ex )
            {
                clsGlobalData.WriteExceptionInLogFile( ex );
                MessageBox.Show( ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            return updated;
        }
        public static bool SetCompleteAppointment( SqlParameter[] parameters )
        {
            bool updated = false;
            try
            {
                using ( SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
                {
                    using ( SqlCommand Command = new SqlCommand( "SP_CompleteAppointment", Connection ) )
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddRange( parameters );

                        Connection.Open();


                        int rowAffected = Command.ExecuteNonQuery();

                        updated = ( rowAffected > 0 );
                    }
                }
            }
            catch ( Exception ex )
            {
                clsGlobalData.WriteExceptionInLogFile( ex );
                MessageBox.Show( ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            return updated;
        }
        public static bool SetComplete( SqlParameter parameter )
        {
            bool updated = false;
            try
            {
                using ( SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
                {
                    using ( SqlCommand Command = new SqlCommand( "SP_SetComplete", Connection ) )
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.Add( parameter );

                        Connection.Open();

                        int rowAfficted = Command.ExecuteNonQuery();

                        updated = ( rowAfficted > 0 );
                    }
                }
            }
            catch ( Exception ex )
            {
                clsGlobalData.WriteExceptionInLogFile( ex );
                MessageBox.Show( ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            return updated;
        }
        public static bool SetCancel( SqlParameter parameter )
        {
            bool updated = false;
            try
            {
                using ( SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
                {
                    using ( SqlCommand Command = new SqlCommand( "SP_SetCancel", Connection ) )
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.Add( parameter );

                        Connection.Open();

                        int rowAfficted = Command.ExecuteNonQuery();

                        updated = ( rowAfficted > 0 );
                    }
                }
            }
            catch ( Exception ex )
            {
                clsGlobalData.WriteExceptionInLogFile( ex );
                MessageBox.Show( ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            return updated;
        }
    }
}


