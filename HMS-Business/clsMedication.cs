using HMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Business
{
    public class clsMedication
    {
        enum enMode
        {
            ADDNEW = 0,
            UPDATE = 1
        }
        public int? MeicationID { get; set; }
        public string MedicationName { get; set; }
        enMode _Mode = enMode.ADDNEW;
        public clsMedication()
        {
            MeicationID = null;
            MedicationName = null;
            _Mode = enMode.ADDNEW;
        }
        clsMedication( int? MedicationID, string MedicationName )
        {
            this.MeicationID = MedicationID;
            this.MedicationName = MedicationName;
            _Mode = enMode.UPDATE;
        }
        public static DataTable GetAllMedications()
        {
            return clsMedicationsDataAccess.GetAllMedications();
        }
        public static clsMedication Find( int? MedicationID )
        {
            SqlParameter[] parameters = new SqlParameter[ 2 ];
            parameters[ 0 ] = new SqlParameter( "MedicationID", MedicationID );
            parameters[ 1 ] = new SqlParameter( "MedicationName", null );
            bool isFound = clsMedicationsDataAccess.FindMedication( ref parameters );
            if ( isFound )
            {
                clsMedication objMedication = new clsMedication();
                objMedication.MeicationID = ( int ) parameters[ 0 ].Value;
                objMedication.MedicationName = parameters[ 1 ].Value.ToString();
                return objMedication;
            }
            else
            {
                return null;
            }
        }
        private bool AddNewMedication( string MedicationName )
        {
            int? MedicationID = null;
            SqlParameter[] parameters = new SqlParameter[ 1 ];
            parameters[ 0 ] = new SqlParameter( "MedicationName", MedicationName );
            MedicationID= clsMedicationsDataAccess.AddNewMedication( parameters );
            return ( MedicationID != null );
        }
        private bool UpdateMedication( int MedicationID, string MedicationName )
        {
            SqlParameter[] parameters = new SqlParameter[ 2 ];
            parameters[ 0 ] = new SqlParameter( "MedicationID", MedicationID );
            parameters[ 1 ] = new SqlParameter( "MedicationName", MedicationName );
            return clsMedicationsDataAccess.UpdateMedication( parameters );
        }
        public static bool DeleteMedication( int MedicationID )
        {
            SqlParameter parameter = new SqlParameter( "MedicationID", MedicationID );
            return clsMedicationsDataAccess.DeleteMedication( parameter );
        }
        public bool Delete()
        {
            return DeleteMedication( ( int ) this.MeicationID );
        }
        public bool Save()
        {
            if ( _Mode == enMode.ADDNEW )
            {
                return AddNewMedication( this.MedicationName );
            }
            else
            {
                return UpdateMedication( ( int ) this.MeicationID, this.MedicationName );
            }
        }
    }
}
