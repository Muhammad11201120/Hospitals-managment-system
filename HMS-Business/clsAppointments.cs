using System;
using HMS_BusinessLayer;
using HMS_DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace HMS_DataBusinessLayer
{
    public class clsAppointments
    {
        public struct stSetCompleteAppointmentWithPrescription
        {
            public int? AppointmentID;
            public string VisitDescription;
            public string Diagnosis;
            public string AdditionalNotes;
            public DateTime? PaymentDate;
            public string PaymentMethod;
            public decimal? AmountPaid;
            public string PayAdditionalNotes;
            public string MedicationName;
            public string Dosage;
            public string Frequency;
            public DateTime? StartDate;
            public DateTime? EndDate;
            public string SpecialInstructions;
        }
        public struct stSetCompleteAppointment
        {
            public int? AppointmentID;
            public string VisitDescription;
            public string Diagnosis;
            public string AdditionalNotes;
            public DateTime? PaymentDate;
            public string PaymentMethod;
            public decimal? AmountPaid;
            public string PayAdditionalNotes;
        }

        //public static stSetCompleteAppointmentWithPrescription setCompleteAppointmentWithPrescription;
        //public static stSetCompleteAppointment setCompleteAppointment;
        public enum enMode { AddNew = 1, Update = 2 }

        public enum enStatus { eNew = 1, eCancel = 2, eComplete };

        public enMode Mode;

        enStatus status;

        public Nullable<int> AppointmentID { get; set; }
        public int PatientID { get; set; }
        public clsPatient PatientInfo
        {
            get
            {
                return clsPatient.FindPatientByPatientID( PatientID );
            }
        }
        public int DoctorID { get; set; }

        public clsDoctor DoctorInfo
        {
            get
            {
                return clsDoctor.Find( DoctorID );
            }
        }
        public DateTime AppointmentDateTime { get; set; }
        public byte AppointmentStatus { get; set; }
        public int UserID { get; set; }
        public clsUser UserInfo
        {
            get
            {
                return clsUser.Find( UserID );
            }

            set
            {

            }
        }
        public decimal TotalPrice { get; set; }

        public clsAppointments()
        {
            this.AppointmentID = default( int );
            this.PatientID = default( int );
            this.DoctorID = default( int );
            this.AppointmentDateTime = default( DateTime );
            this.AppointmentStatus = 1;
            this.UserID = default( int );
            this.TotalPrice = default( decimal );

            this.Mode = enMode.AddNew;
        }

        private clsAppointments( int appointmentid, int patientid, int doctorid, DateTime appointmentdatetime, byte appointmentstatus,
                                int userid, decimal totalprice )
        {
            this.AppointmentID = appointmentid;
            this.PatientID = patientid;
            this.DoctorID = doctorid;
            this.AppointmentDateTime = appointmentdatetime;
            this.AppointmentStatus = appointmentstatus;
            this.UserID = userid;
            this.TotalPrice = totalprice;

            this.Mode = enMode.Update;
        }

        private bool _AddNewAppointments()
        {
            // parameters
            SqlParameter[] parameters = new SqlParameter[ 6 ];
            parameters[ 0 ] = new SqlParameter( "PatientID", this.PatientID );
            parameters[ 1 ] = new SqlParameter( "DoctorID", this.DoctorID );
            parameters[ 2 ] = new SqlParameter( "AppointmentDateTime", this.AppointmentDateTime );
            parameters[ 3 ] = new SqlParameter( "AppointmentStatus", ( byte ) enStatus.eNew );
            parameters[ 4 ] = new SqlParameter( "UserID", this.UserID );
            parameters[ 5 ] = new SqlParameter( "TotalPrice", this.TotalPrice );

            this.AppointmentID = clsAppointmentsData.AddNewAppointment( parameters );

            return ( this.AppointmentID != null );
        }

        private bool _UpdateAppointments()
        {
            // parameters
            SqlParameter[] parameters = new SqlParameter[ 7 ];
            parameters[ 0 ] = new SqlParameter( "AppointmentID", this.AppointmentID );
            parameters[ 1 ] = new SqlParameter( "PatientID", this.PatientID );
            parameters[ 2 ] = new SqlParameter( "DoctorID", this.DoctorID );
            parameters[ 3 ] = new SqlParameter( "AppointmentDateTime", this.AppointmentDateTime );
            parameters[ 4 ] = new SqlParameter( "AppointmentStatus", this.AppointmentStatus );
            parameters[ 5 ] = new SqlParameter( "UserID", this.UserID );
            parameters[ 6 ] = new SqlParameter( "TotalPrice", this.TotalPrice );

            return clsAppointmentsData.UpdateAppointment( parameters );
        }

        public bool Save()
        {
            switch ( Mode )
            {
                case enMode.AddNew:
                    if ( _AddNewAppointments() )
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateAppointments();

            }
            return false;
        }

        public static clsAppointments FindByAppointmentID( int? AppointmentID )
        {
            // parameters
            SqlParameter[] parameters = new SqlParameter[ 7 ];
            parameters[ 0 ] = new SqlParameter( "AppointmentID", AppointmentID );
            parameters[ 1 ] = new SqlParameter( "PatientID", null );
            parameters[ 2 ] = new SqlParameter( "DoctorID", null );
            parameters[ 3 ] = new SqlParameter( "AppointmentDateTime", null );
            parameters[ 4 ] = new SqlParameter( "AppointmentStatus", null );
            parameters[ 5 ] = new SqlParameter( "UserID", null );
            parameters[ 6 ] = new SqlParameter( "TotalPrice", null );

            if ( clsAppointmentsData.FindAppointment( ref parameters ) )
            {
                return new clsAppointments( ( int ) parameters[ 0 ].Value, ( int ) parameters[ 1 ].Value, ( int ) parameters[ 2 ].Value, ( DateTime ) parameters[ 3 ].Value, ( byte ) parameters[ 4 ].Value, ( int ) parameters[ 5 ].Value, ( decimal ) parameters[ 6 ].Value );
            }
            else
                return null;

        }

        public static bool IsExist( int AppointmentID )
        {
            SqlParameter parameter = new SqlParameter( "AppointmentID", AppointmentID );

            return clsAppointmentsData.IsAppointmentExists( parameter );
        }

        public static bool Delete( int AppointmentID )
        {
            SqlParameter parameter = new SqlParameter( "AppointmentID", AppointmentID );

            return clsAppointmentsData.DeleteAppointment( parameter );
        }

        public static DataTable GetAllAppointments()
        { 

            return clsAppointmentsData.GetAllAppointments();
        }
        public static bool IsAppointmentExistByDoctorIDAndDate( int DoctorID, short Year, byte Month, byte Day, byte Hour )
        {
            SqlParameter[] parameters = new SqlParameter[ 5 ];
            parameters[ 0 ] = new SqlParameter( "DoctorID", DoctorID );
            parameters[ 1 ] = new SqlParameter( "Year", Year );
            parameters[ 2 ] = new SqlParameter( "Month", Month );
            parameters[ 3 ] = new SqlParameter( "Day", Day );
            parameters[ 4 ] = new SqlParameter( "Hour", Hour );
            return clsAppointmentsData.IsAppointmentExistByDoctorIDAndDate( parameters );
        }
        public static bool IsAppointmentExistByPatientIDAndDate( int DoctorID, short Year, byte Month, byte Day, byte Hour )
        {
            SqlParameter[] parameters = new SqlParameter[ 5 ];
            parameters[ 0 ] = new SqlParameter( "PatientID", DoctorID );
            parameters[ 1 ] = new SqlParameter( "Year", Year );
            parameters[ 2 ] = new SqlParameter( "Month", Month );
            parameters[ 3 ] = new SqlParameter( "Day", Day );
            parameters[ 4 ] = new SqlParameter( "Hour", Hour );
            return clsAppointmentsData.IsAppointmentExistByPatientIDAndDate( parameters );
        }
        public static DataTable GetAllAppointmentsDateByDoctorAndDate( int DoctorID, short Year, byte Month, byte Day )
        {
            SqlParameter[] parameters = new SqlParameter[ 4 ];
            parameters[ 0 ] = new SqlParameter( "DoctorID", DoctorID );
            parameters[ 1 ] = new SqlParameter( "Year", Year );
            parameters[ 2 ] = new SqlParameter( "Month", Month );
            parameters[ 3 ] = new SqlParameter( "Day", Day );
            return clsAppointmentsData.GetAllAppointmentsDateByDoctorAndDate( parameters );
        }
        public static DataTable GetAllAppointmentsHourByDoctorAndDate( int DoctorID, short Year, byte Month, byte Day )
        {
            SqlParameter[] parameters = new SqlParameter[ 4 ];
            parameters[ 0 ] = new SqlParameter( "DoctorID", DoctorID );
            parameters[ 1 ] = new SqlParameter( "Year", Year );
            parameters[ 2 ] = new SqlParameter( "Month", Month );
            parameters[ 3 ] = new SqlParameter( "Day", Day );
            return clsAppointmentsData.GetAllAppointmentsHourByDoctorAndDate( parameters );

        }
        public static bool SetCompleteAppointmentWithPrescription( stSetCompleteAppointmentWithPrescription AppointmentWithPrescription )
        {

            SqlParameter[] parameters = new SqlParameter[ 14 ];
            parameters[ 0 ]  = new SqlParameter( "AppointmentID", AppointmentWithPrescription.AppointmentID );
            parameters[ 1 ]  = new SqlParameter( "VisitDescription", AppointmentWithPrescription.VisitDescription );
            parameters[ 2 ]  = new SqlParameter( "Diagnosis", AppointmentWithPrescription.Diagnosis );
            parameters[ 3 ]  = new SqlParameter( "AdditionalNotes", AppointmentWithPrescription.AdditionalNotes );
            parameters[ 4 ]  = new SqlParameter( "PaymentDate", AppointmentWithPrescription.PaymentDate );
            parameters[ 5 ]  = new SqlParameter( "PaymentMethod", AppointmentWithPrescription.PaymentMethod );
            parameters[ 6 ]  = new SqlParameter( "AmountPaid", AppointmentWithPrescription.AmountPaid );
            parameters[ 7 ]  = new SqlParameter( "PayAdditionalNotes", AppointmentWithPrescription.PayAdditionalNotes );
            parameters[ 8 ]  = new SqlParameter( "MedicationName", AppointmentWithPrescription.MedicationName );
            parameters[ 9 ]  = new SqlParameter( "Dosage", AppointmentWithPrescription.Dosage );
            parameters[ 10 ] = new SqlParameter( "Frequency", AppointmentWithPrescription.Frequency );
            parameters[ 11 ] = new SqlParameter( "StartDate", AppointmentWithPrescription.StartDate );
            parameters[ 12 ] = new SqlParameter( "EndDate", AppointmentWithPrescription.EndDate );
            parameters[ 13 ] = new SqlParameter( "SpecialInstruction", AppointmentWithPrescription.SpecialInstructions );

            return clsAppointmentsData.SetCompleteAppointmentWithPrescription( parameters );
        }
        public static bool SetCompleteAppointment( stSetCompleteAppointment Appointment )
        {
            SqlParameter[] parameters = new SqlParameter[ 8 ];
            parameters[ 0 ] = new SqlParameter( "AppointmentID", Appointment.AppointmentID );
            parameters[ 1 ] = new SqlParameter( "VisitDescription", Appointment.VisitDescription );
            parameters[ 2 ] = new SqlParameter( "Diagnosis", Appointment.Diagnosis );
            parameters[ 3 ] = new SqlParameter( "AdditionalNotes", Appointment.AdditionalNotes );
            parameters[ 4 ] = new SqlParameter( "PaymentDate", Appointment.PaymentDate );
            parameters[ 5 ] = new SqlParameter( "PaymentMethod", Appointment.PaymentMethod );
            parameters[ 6 ] = new SqlParameter( "AmountPaid", Appointment.AmountPaid );
            parameters[ 7 ] = new SqlParameter( "PayAdditionalNotes", Appointment.PayAdditionalNotes );

            return clsAppointmentsData.SetCompleteAppointment( parameters );
        }
        public bool SetComplete()
        {
            if ( this.AppointmentID == null )
                return false;

            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "AppointmentID",
                Value= this.AppointmentID
            };
            return clsAppointmentsData.SetComplete( parameter );
        }
        public bool SetCancel()
        {
            if ( this.AppointmentID == null )
                return false;

            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "AppointmentID",
                Value = this.AppointmentID
            };
            return clsAppointmentsData.SetComplete( parameter );
        }

    }
}
