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
    public class clsPatients : clsPerson
    {
        enum _enMode
        {
            ADD = 1,
            UPDATE = 2,
        }
        public int? PatientID { get; set; }
        _enMode _Mode = _enMode.ADD;

        public clsPatients()
        {
            PatientID = null;
            _Mode = _enMode.ADD;
        }
        public clsPatients( int? patientID, int? personID, string firstName, string lastName, DateTime dateOfBirth, short? gendor, string address, int? contactID, int? countryID )
            : base( personID, firstName, lastName, dateOfBirth, gendor, address, contactID, countryID )
        {
            this.PatientID = patientID;
            this.PersonID = personID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gendor = gendor;
            this.Address = address;
            this.ContactID = contactID;
            this.CountryID = countryID;
            _Mode = _enMode.UPDATE;
        }
        public static DataTable GetAllPatients()
        {
            return clsPatientsData.GetAllPatients();
        }
        public static clsPatients FindPatientByPatientID( int? PatientID )
        {

            int? PersonID = null;
            SqlParameter[] parameter = new SqlParameter[ 2 ];
            parameter[ 0 ] = new SqlParameter( "@PatientID", PatientID );
            parameter[ 1 ] = new SqlParameter( "@PersonID", null );
            if ( clsPatientsData.FindPatient( ref parameter ) )
            {
                clsPerson person = Find( PersonID );
                return new clsPatients( PatientID, PersonID, person.FirstName, person.LastName, person.DateOfBirth, person.Gendor, person.Address, person.ContactID, person.CountryID );
            }
            else
                return null;
        }

    }

}

