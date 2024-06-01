using HMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataBusinessLayer
{
    public class clsPatient : clsPerson
    {
        enum _enMode
        {
            ADD = 1,
            UPDATE = 2,
        }
        public int? PatientID { get; set; }

        _enMode _Mode = _enMode.ADD;

        public clsPatient()
        {
            PatientID = null;
            PersonID = null;
            _Mode = _enMode.ADD;
        }
        public clsPatient( int? patientID, int? personID, string nationalNo, string firstName, string lastName, DateTime dateOfBirth, byte? gender, string address, int? contactID, int? countryID )

        {
            this.PatientID = patientID;
            this.PersonID = personID;
            this.NationalNo = nationalNo;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Address = address;
            this.ContactID = contactID;
            this.CountryID = countryID;
            _Mode = _enMode.UPDATE;
        }
        public static DataTable GetAllPatients()
        {
            return clsPatientsData.GetAllPatients();
        }
        public static clsPatient FindPatientByPatientID( int? PatientID )
        {

            SqlParameter[] parameter = new SqlParameter[ 2 ];
            parameter[ 0 ] = new SqlParameter( "PatientID", PatientID );
            parameter[ 1 ] = new SqlParameter( "PersonID", null );
            bool isFound = clsPatientsData.FindPatient( ref parameter );
            if ( isFound )
            {
                clsPerson person = Find( ( int ) parameter[ 1 ].Value );
                return new clsPatient( ( int ) parameter[ 0 ].Value, person.PersonID, person.NationalNo, person.FirstName, person.LastName, person.DateOfBirth, person.Gender, person.Address, person.ContactID, person.CountryID );
            }
            else
                return null;
        }
        private bool _AddNewPatient()
        {
            SqlParameter[] parameters = new SqlParameter[ 1 ];
            parameters[ 0 ] = new SqlParameter( "PersonID", this.PersonID );


            this.PatientID = clsPatientsData.AddNewPatient( parameters );
            return ( this.PatientID != null );
        }
        private bool _UpdatePatient()
        {
            SqlParameter[] parameters = new SqlParameter[ 2 ];
            parameters[ 0 ] = new SqlParameter( "PatientID", this.PatientID );
            parameters[ 1 ] = new SqlParameter( "PersonID", this.PersonID );


            return clsPatientsData.UpdatePatient( parameters );
        }
        public new bool Delete()
        {
            SqlParameter parameter = new SqlParameter( "PatientID", this.PatientID );
            if ( clsPatientsData.DeletePatient( parameter ) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static new bool Delete( int? PatientID )
        {
            SqlParameter parameter = new SqlParameter( "PatientID", PatientID );
            if ( clsPatientsData.DeletePatient( parameter ) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public new bool Save()
        {
            base.Mode = ( clsPerson.enMode ) _Mode;
            if ( !base.Save() )
                return false;

            switch ( _Mode )
            {
                case _enMode.ADD:
                    if ( _AddNewPatient() )
                    {
                        _Mode = _enMode.UPDATE;
                        return true;
                    }
                    else
                        return false;
                case _enMode.UPDATE:
                    return _UpdatePatient();

            }
            return false;
        }
    }

}

