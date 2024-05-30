﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HMS_DataAccessLayer
{
    public class clsSpecialityData
    {

        public static Nullable<int> AddNewSpecialtie( SqlParameter[] parameters )
        {
            Nullable<int> SpecialityID = null;

            try
            {

                using ( SqlConnection connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
                {
                    connection.Open();

                    using ( SqlCommand Command = new SqlCommand( "SP_AddNewSpeciality", connection ) )
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddRange( parameters );

                        SqlParameter outputParameter = new SqlParameter( "@NewSpecialityID", SqlDbType.Int )
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add( outputParameter );

                        Command.ExecuteNonQuery();

                        SpecialityID = ( int ) Command.Parameters[ "@NewSpecialityID" ].Value;
                    }
                }
            }

            catch ( Exception ex )
            {
                clsGlobalData.WriteExceptionInLogFile( ex );
                MessageBox.Show( "Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }

            return SpecialityID;
        }

        public static bool FindSpecialityByNaem( ref SqlParameter[] parameters )
        {
            bool Found = false;

            using ( SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
            using ( SqlCommand Command = new SqlCommand( "SP_GetSpecialtyByName", Connection ) )
            {
                Command.CommandType = CommandType.StoredProcedure;

                Command.Parameters.AddWithValue( $"@{parameters[ 1 ].ParameterName}", parameters[ 1 ].Value );

                try
                {
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
                catch ( Exception ex )
                {
                    clsGlobalData.WriteExceptionInLogFile( ex );
                    MessageBox.Show( $"Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }

            return Found;
        }
        public static bool FindSpeciality( ref SqlParameter[] parameters )
        {
            bool Found = false;

            using ( SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
            using ( SqlCommand Command = new SqlCommand( "SP_GetSpecialityByID", Connection ) )
            {
                Command.CommandType = CommandType.StoredProcedure;

                Command.Parameters.AddWithValue( $"@{parameters[ 0 ].ParameterName}", parameters[ 0 ].Value );

                try
                {
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
                catch ( Exception ex )
                {
                    clsGlobalData.WriteExceptionInLogFile( ex );
                    MessageBox.Show( $"Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }

            return Found;
        }

        public static bool UpdateSpeciality( SqlParameter[] parameters )
        {
            bool Updated = false;

            using ( SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
            using ( SqlCommand Command = new SqlCommand( "SP_UpdateSpeciality", Connection ) )
            {
                Command.CommandType = CommandType.StoredProcedure;

                Command.Parameters.AddRange( parameters );

                try
                {
                    Connection.Open();

                    int rowAfficted = Command.ExecuteNonQuery();

                    Updated = ( rowAfficted > 0 );
                }
                catch ( Exception ex )
                {
                    clsGlobalData.WriteExceptionInLogFile( ex );
                    MessageBox.Show( $"Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }

            }

            return Updated;
        }

        public static bool IsSpecialityExists( SqlParameter parameter )
        {
            bool Exists = false;

            using ( SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
            using ( SqlCommand Command = new SqlCommand( "SP_IsSpecialityExist", Connection ) )
            {
                Command.CommandType = CommandType.StoredProcedure;

                Command.Parameters.AddWithValue( parameter.ParameterName, parameter.Value );

                SqlParameter returnValue = new SqlParameter
                {
                    Direction = ParameterDirection.ReturnValue
                };
                Command.Parameters.Add( returnValue );

                try
                {
                    Connection.Open();

                    Command.ExecuteScalar();
                    int result = ( int ) returnValue.Value;

                    Exists = ( result == 1 );
                }
                catch ( Exception ex )
                {
                    clsGlobalData.WriteExceptionInLogFile( ex );
                    MessageBox.Show( $"Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }

            return Exists;
        }

        public static bool DeleteSpeciality( SqlParameter parameter )
        {
            bool Deleted = false;

            using ( SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
            using ( SqlCommand Command = new SqlCommand( "SP_DeleteSpeciality", Connection ) )
            {
                Command.CommandType = CommandType.StoredProcedure;

                Command.Parameters.AddWithValue( parameter.ParameterName, parameter.Value );


                try
                {
                    Connection.Open();

                    int rowAfficted = Command.ExecuteNonQuery();

                    Deleted = ( rowAfficted > 0 );
                }
                catch ( Exception ex )
                {
                    clsGlobalData.WriteExceptionInLogFile( ex );
                    MessageBox.Show( $"Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }

            return Deleted;
        }
        public static DataTable GetAllSpecialties()
        {
            DataTable dt = new DataTable();

            using ( SqlConnection connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
            using ( SqlCommand command = new SqlCommand( "SP_GetAllSpecialties", connection ) )
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();

                    using ( SqlDataReader reader = command.ExecuteReader() )
                    {
                        if ( reader.HasRows )
                        {
                            dt.Load( reader );
                        }
                    }

                }
                catch ( Exception ex )
                {
                    clsGlobalData.WriteExceptionInLogFile( ex );
                    MessageBox.Show( $"Error SP_GetAllSpecialties : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }


            return dt;
        }


    }
}
