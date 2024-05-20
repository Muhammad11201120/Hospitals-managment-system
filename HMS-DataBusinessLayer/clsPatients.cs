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
            _Mode = _enMode.UPDATE;
        }
        public static DataTable GetAllPatients()
        {
            return clsPatientsData.GetAllPatients();
        }
        public new clsPatients Find( int? PatientID )
        {
            clsPerson person = clsPerson.Find( base.PersonID );
            if ( person != null )
            {
                SqlParameter[] parameter = new SqlParameter[ 1 ];
                parameter[ 0 ] = new SqlParameter( "PatientID", PatientID );
                if ( clsPatientsData.FindPatient( ref parameter ) )
                {
                    return new clsPatients( PatientID, person.PersonID, person.FirstName, person.LastName, person.DateOfBirth, person.Gendor, person.Address, person.ContactID, person.CountryID );
                }
                else
                    return null;
            }
            else
                return null;
        }

    }
}
