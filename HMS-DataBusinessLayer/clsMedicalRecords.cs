using HMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataBusinessLayer
{
    public class clsMedicalRecords
    {

        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode;

        public Nullable<int> MedicalRecordID { get; set; }
        public string VisitDescription { get; set; }
        public string Diagnosis { get; set; }
        public int AppointmentID { get; set; }
        public string AdditionalNotes { get; set; }

        public clsMedicalRecords()
        {
            this.MedicalRecordID = default( int );
            this.VisitDescription = default( string );
            this.Diagnosis = default( string );
            this.AppointmentID = default( int );
            this.AdditionalNotes = default( string );

            this.Mode = enMode.AddNew;
        }

        private clsMedicalRecords( int medicalrecordid, string visitdescription, string diagnosis, int appointmentid, string additionalnotes )
        {
            this.MedicalRecordID = medicalrecordid;
            this.VisitDescription = visitdescription;
            this.Diagnosis = diagnosis;
            this.AppointmentID = appointmentid;
            this.AdditionalNotes = additionalnotes;

            this.Mode = enMode.Update;
        }

        private bool _AddNewMedicalRecords()
        {
            // parameters
            SqlParameter[] parameters = new SqlParameter[ 4 ];
            parameters[ 0 ] = new SqlParameter( "VisitDescription", this.VisitDescription );
            parameters[ 1 ] = new SqlParameter( "Diagnosis", this.Diagnosis );
            parameters[ 2 ] = new SqlParameter( "AppointmentID", this.AppointmentID );
            parameters[ 3 ] = new SqlParameter( "AdditionalNotes", this.AdditionalNotes );

            this.MedicalRecordID = clsMedicalRecordsData.AddNewMedicalRecord( parameters );

            return ( this.MedicalRecordID != null );
        }

        private bool _UpdateMedicalRecords()
        {
            // parameters
            SqlParameter[] parameters = new SqlParameter[ 5 ];
            parameters[ 0 ] = new SqlParameter( "MedicalRecordID", this.MedicalRecordID );
            parameters[ 1 ] = new SqlParameter( "VisitDescription", this.VisitDescription );
            parameters[ 2 ] = new SqlParameter( "Diagnosis", this.Diagnosis );
            parameters[ 3 ] = new SqlParameter( "AppointmentID", this.AppointmentID );
            parameters[ 4 ] = new SqlParameter( "AdditionalNotes", this.AdditionalNotes );

            return clsMedicalRecordsData.UpdateMedicalRecord( parameters );
        }

        public bool Save()
        {
            switch ( Mode )
            {
                case enMode.AddNew:
                    if ( _AddNewMedicalRecords() )
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateMedicalRecords();

            }
            return false;
        }

        public static clsMedicalRecords FindByMedicalRecordID( int MedicalRecordID )
        {
            // parameters
            SqlParameter[] parameters = new SqlParameter[ 5 ];
            parameters[ 0 ] = new SqlParameter( "MedicalRecordID", MedicalRecordID );
            parameters[ 1 ] = new SqlParameter( "VisitDescription", null );
            parameters[ 2 ] = new SqlParameter( "Diagnosis", null );
            parameters[ 3 ] = new SqlParameter( "AppointmentID", null );
            parameters[ 4 ] = new SqlParameter( "AdditionalNotes", null );


            if ( clsMedicalRecordsData.FindMedicalRecord( ref parameters ) )
            {
                return new clsMedicalRecords( ( int ) parameters[ 0 ].Value, ( string ) parameters[ 1 ].Value, ( string ) parameters[ 2 ].Value, ( int ) parameters[ 3 ].Value, ( string ) parameters[ 4 ].Value );
            }
            else
                return null;

        }

        public static bool IsExist( int MedicalRecordID )
        {
            SqlParameter parameter = new SqlParameter( "MedicalRecordID", MedicalRecordID );

            return clsMedicalRecordsData.IsMedicalRecordExists( parameter );
        }

        public static bool Delete( int MedicalRecordID )
        {
            SqlParameter parameter = new SqlParameter( "MedicalRecordID", MedicalRecordID );

            return clsMedicalRecordsData.DeleteMedicalRecord( parameter );
        }

    }
}
