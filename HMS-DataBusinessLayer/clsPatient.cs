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
            _Mode = _enMode.ADD;
        }
        public clsPatient( int? patientID, int? personID, string firstName, string lastName, DateTime dateOfBirth, short? gender, string address, int? contactID, int? countryID )
            : base( personID, firstName, lastName, dateOfBirth, gender, address, contactID, countryID )
        {
            this.PatientID = patientID;
            this.PersonID = personID;
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

            int? PersonID = null;
            SqlParameter[] parameter = new SqlParameter[ 2 ];
            parameter[ 0 ] = new SqlParameter( "PatientID", PatientID );
            parameter[ 1 ] = new SqlParameter( "PersonID", null );
            if ( clsPatientsData.FindPatient( ref parameter ) )
            {
                clsPerson person = Find( PersonID );
                return new clsPatient( PatientID, PersonID, person.FirstName, person.LastName, person.DateOfBirth, person.Gender, person.Address, person.ContactID, person.CountryID );
            }
            else
                return null;
        }
        private bool _AddNewPatient()
        {
            SqlParameter[] parameters = new SqlParameter[ 8 ];
            parameters[ 7 ] = new SqlParameter( "PersonID", this.PersonID );
            parameters[ 0 ] = new SqlParameter( "FirstName", this.FirstName );
            parameters[ 1 ] = new SqlParameter( "LastName", this.LastName );
            parameters[ 2 ] = new SqlParameter( "DateOfBirth", this.DateOfBirth );
            parameters[ 3 ] = new SqlParameter( "Gendor", this.Gender );
            parameters[ 4 ] = new SqlParameter( "Address", this.Address );
            parameters[ 5 ] = new SqlParameter( "ContactID", this.ContactID );
            parameters[ 6 ] = new SqlParameter( "CountryID", this.CountryID );

            this.PatientID = clsPatientsData.AddNewPatient( parameters );
            return ( this.PatientID != null );
        }
        private bool _UpdatePatient()
        {
            SqlParameter[] parameters = new SqlParameter[ 9 ];
            parameters[ 0 ] = new SqlParameter( "PatientID", this.PatientID );
            parameters[ 1 ] = new SqlParameter( "PersonID", this.PersonID );
            parameters[ 2 ] = new SqlParameter( "FirstName", this.FirstName );
            parameters[ 3 ] = new SqlParameter( "LastName", this.LastName );
            parameters[ 4 ] = new SqlParameter( "DateOfBirth", this.DateOfBirth );
            parameters[ 5 ] = new SqlParameter( "Gendor", this.Gender );
            parameters[ 6 ] = new SqlParameter( "Address", this.Address );
            parameters[ 7 ] = new SqlParameter( "ContactID", this.ContactID );
            parameters[ 8 ] = new SqlParameter( "CountryID", this.CountryID );

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

