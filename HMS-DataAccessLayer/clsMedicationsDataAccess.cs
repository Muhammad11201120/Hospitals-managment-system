using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_DataAccessLayer
{
    public class clsMedicationsDataAccess
    {
        public static DataTable GetAllMedications()
        {
            DataTable dtMedications = new DataTable();
            try
            {
                using ( SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
                {
                    Connection.Open();
                    string query = @"exec SP_GetAllMedications";
                    using ( SqlCommand Command = new SqlCommand( query, Connection ) )
                    {
                        using ( SqlDataReader reader = Command.ExecuteReader() )
                        {
                            if ( reader.HasRows )
                                dtMedications.Load( reader );
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
            return dtMedications;
        }
        public static bool FindMedication( ref SqlParameter[] parameters )
        {
            bool isFound = false;
            try
            {
                using ( SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
                {
                    Connection.Open();

                    using ( SqlCommand Command = new SqlCommand( "SP_GetEmpolyeeByID", Connection ) )
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue( $"@{parameters[ 0 ].ParameterName}", parameters[ 0 ].Value );

                        using ( SqlDataReader reader = Command.ExecuteReader() )
                        {
                            if ( reader.Read() )
                            {
                                for ( int i = 0; i < reader.FieldCount; i++ )
                                {
                                    parameters[ i ].Value = reader[ parameters[ i ].ParameterName ];
                                }

                                isFound = true;
                            }
                        }
                    }
                }
            }
            catch ( Exception ex )
            {
                clsGlobalData.WriteExceptionInLogFile( ex );
                MessageBox.Show( "Error SP_GetPersonByID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            return isFound;
        }
        public static Nullable<int> AddNewMedication( SqlParameter[] parameters )
        {
            Nullable<int> MedicationID = null;
            try
            {
                using ( SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
                {
                    Connection.Open();

                    using ( SqlCommand Command = new SqlCommand( "SP_AddNewMedication", Connection ) )
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddRange( parameters );

                        SqlParameter outputParameter = new SqlParameter( "@NewMedicationID", SqlDbType.Int )
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add( outputParameter );

                        Command.ExecuteNonQuery();

                        MedicationID = ( int ) Command.Parameters[ "@NewMedicationID" ].Value;
                    }
                }
            }
            catch ( Exception ex )
            {
                clsGlobalData.WriteExceptionInLogFile( ex );
                MessageBox.Show( "Error SP_AddNewMedication: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            return MedicationID;
        }
        public static bool UpdateMedication( SqlParameter[] parameters )
        {
            bool Updated = false;
            try
            {
                using ( SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
                {
                    Connection.Open();

                    using ( SqlCommand Command = new SqlCommand( "SP_UpdateMedication", Connection ) )
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddRange( parameters );

                        int RowAffected = Command.ExecuteNonQuery();

                        if ( RowAffected > 0 )
                            Updated = true;
                    }
                }
            }
            catch ( Exception ex )
            {
                clsGlobalData.WriteExceptionInLogFile( ex );
                MessageBox.Show( "Error SP_UpdateMedication: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            return Updated;
        }
        public static bool DeleteMedication( SqlParameter parameter )
        {
            bool Deleted = false;
            try
            {
                using ( SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString ) )
                {
                    Connection.Open();

                    using ( SqlCommand Command = new SqlCommand( "SP_DeleteMedication", Connection ) )
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.Add( parameter );

                        int RowAffected = Command.ExecuteNonQuery();

                        if ( RowAffected > 0 )
                            Deleted = true;
                    }
                }
            }
            catch ( Exception ex )
            {
                clsGlobalData.WriteExceptionInLogFile( ex );
                MessageBox.Show( "Error SP_DeleteMedication: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            return Deleted;
        }
    }
}
