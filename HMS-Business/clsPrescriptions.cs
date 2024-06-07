using HMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataBusinessLayer
{
    public class clsPrescriptions
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode;

        public Nullable<int> PrescriptionID { get; set; }
        public int MedicalRecordID { get; set; }
        public int? MedicationID { get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string SpecialInstructions { get; set; }

        public clsPrescriptions()
        {
            this.PrescriptionID = default( int );
            this.MedicalRecordID = default( int );
            this.MedicationID = default( int );
            this.Dosage = default( string );
            this.Frequency = default( string );
            this.StartDate = default( DateTime );
            this.EndDate = default( DateTime );
            this.SpecialInstructions = default( string );

            this.Mode = enMode.AddNew;
        }

        private clsPrescriptions( int prescriptionid, int medicalrecordid, int medicationID, string dosage, string frequency, DateTime startdate, DateTime enddate, string specialinstructions )
        {
            this.PrescriptionID = prescriptionid;
            this.MedicalRecordID = medicalrecordid;
            this.MedicationID = medicationID;
            this.Dosage = dosage;
            this.Frequency = frequency;
            this.StartDate = startdate;
            this.EndDate = enddate;
            this.SpecialInstructions = specialinstructions;

            this.Mode = enMode.Update;
        }

        private bool _AddNewPrescriptions()
        {
            SqlParameter[] parameters = new SqlParameter[ 7 ];
            parameters[ 0 ] = new SqlParameter( "MedicalRecordID", this.MedicalRecordID );
            parameters[ 1 ] = new SqlParameter( "MedicationID", this.MedicationID );
            parameters[ 2 ] = new SqlParameter( "Dosage", this.Dosage );
            parameters[ 3 ] = new SqlParameter( "Frequency", this.Frequency );
            parameters[ 4 ] = new SqlParameter( "StartDate", this.StartDate );
            parameters[ 5 ] = new SqlParameter( "EndDate", this.EndDate );
            parameters[ 6 ] = new SqlParameter( "SpecialInstructions", this.SpecialInstructions );

            this.PrescriptionID = clsPatientsData.AddNewPatient( parameters );

            return ( this.PrescriptionID != null );
        }

        private bool _UpdatePrescriptions()
        {
            SqlParameter[] parameters = new SqlParameter[ 8 ];
            parameters[ 0 ] = new SqlParameter( "PrescriptionID", this.PrescriptionID );
            parameters[ 1 ] = new SqlParameter( "MedicalRecordID", this.MedicalRecordID );
            parameters[ 2 ] = new SqlParameter( "MedicationID", this.MedicationID );
            parameters[ 3 ] = new SqlParameter( "Dosage", this.Dosage );
            parameters[ 4 ] = new SqlParameter( "Frequency", this.Frequency );
            parameters[ 5 ] = new SqlParameter( "StartDate", this.StartDate );
            parameters[ 6 ] = new SqlParameter( "EndDate", this.EndDate );
            parameters[ 7 ] = new SqlParameter( "SpecialInstructions", this.SpecialInstructions );

            return clsPrescriptionsData.UpdatePrescription( parameters );

        }

        public bool Save()
        {
            switch ( Mode )
            {
                case enMode.AddNew:
                    if ( _AddNewPrescriptions() )
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdatePrescriptions();

            }
            return false;
        }

        public static clsPrescriptions FindByPrescriptionID( int PrescriptionID )
        {

            SqlParameter[] parameters = new SqlParameter[ 8 ];
            parameters[ 0 ] = new SqlParameter( "PrescriptionID", PrescriptionID );
            parameters[ 1 ] = new SqlParameter( "MedicalRecordID", null );
            parameters[ 2 ] = new SqlParameter( "MedicationID", null );
            parameters[ 3 ] = new SqlParameter( "Dosage", null );
            parameters[ 4 ] = new SqlParameter( "Frequency", null );
            parameters[ 5 ] = new SqlParameter( "StartDate", null );
            parameters[ 6 ] = new SqlParameter( "EndDate", null );
            parameters[ 7 ] = new SqlParameter( "SpecialInstructions", null );

            if ( clsPrescriptionsData.FindPrescription( ref parameters ) )
            {
                return new clsPrescriptions( ( int ) parameters[ 0 ].Value, ( int ) parameters[ 1 ].Value,
                    ( int ) parameters[ 2 ].Value, ( string ) parameters[ 3 ].Value,
                    ( string ) parameters[ 4 ].Value, ( DateTime ) parameters[ 5 ].Value,
                    ( DateTime ) parameters[ 6 ].Value, ( string ) parameters[ 7 ].Value );
            }
            else
                return null;

        }

        public static bool IsExist( int PrescriptionID )
        {
            SqlParameter parameter = new SqlParameter( "PrescriptionID", PrescriptionID );

            return clsPrescriptionsData.IsPrescriptionExists( parameter );
        }

        public static bool Delete( int PrescriptionID )
        {
            SqlParameter parameter = new SqlParameter( "PrescriptionID", PrescriptionID );

            return clsPrescriptionsData.DeletePrescription( parameter );
        }

    }

}
