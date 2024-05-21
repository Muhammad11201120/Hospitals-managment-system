using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HMS_DataAccessLayer;
namespace HMS_DataBusinessLayer
{
    public class clsPerson
    {
        enum _enMode
        {
            ADD = 0,
            UPDATE = 1
        }
        public int? PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public short? Gendor { get; set; }
        public string Address { get; set; }
        public int? ContactID { get; set; }
        public int? CountryID { get; set; }
        private _enMode _Mode = _enMode.ADD;
        public clsPerson()
        {
            PersonID = null;
            FirstName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = DateTime.Now;
            Gendor = null;
            Address = string.Empty;
            ContactID = null;
            CountryID = null;
            _Mode = _enMode.ADD;
        }
        public clsPerson( int? personID, string firstName, string lastName, DateTime dateOfBirth, short? gendor, string address, int? contactID, int? countryID )
        {
            PersonID = personID;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gendor = gendor;
            Address = address;
            ContactID = contactID;
            CountryID = countryID;
            _Mode = _enMode.UPDATE;
        }

        public static DataTable GetAllPeople()
        {
            return clsPeopleData.GetAllPeople();
        }

        public static clsPerson Find( int? PersonID )
        {
            string FirstName = null, LastName = null, Address = null;
            int? CountryID = null, ContactID = null;
            short? Gendor = null;
            DateTime DateOfBirth = DateTime.Now;
            SqlParameter[] Parameter = new SqlParameter[] {
                new SqlParameter ("@PersonID", PersonID),
                new SqlParameter ("@FirstName", FirstName),
                new SqlParameter ("@LastName", LastName),
                new SqlParameter ("@DateOfBirth", DateOfBirth),
                new SqlParameter ("@Gendor", Gendor),
                new SqlParameter ("@Address", Address),
                new SqlParameter ("@ContactID", ContactID),
                new SqlParameter ("@CountryID", CountryID)
            };
            bool isFound = clsPeopleData.GetPersonByID( ref Parameter );
            if ( isFound )
                return new clsPerson( PersonID, FirstName, LastName, DateOfBirth, Gendor, Address, ContactID, CountryID );
            else
                return null;
        }

        private bool _AddNewPerson()
        {
            SqlParameter[] Parameter = new SqlParameter[]
            {

                new SqlParameter ("@FirstName",this.FirstName ),
                new SqlParameter ("@LastName", this.LastName),
                new SqlParameter ("@DateOfBirth", this.DateOfBirth),
                new SqlParameter ("@Gendor", this.Gendor),
                new SqlParameter ("@Address", this.Address),
                new SqlParameter ("@ContactID", this.ContactID),
                new SqlParameter ("@CountryID", this.CountryID)
            };
            int? personID = clsPeopleData.AddNewPerson( Parameter );
            return ( personID != null );
        }

        private bool _UpdatePerson()
        {
            SqlParameter[] Parameter = new SqlParameter[]
            {
                new SqlParameter ("@PersonID", this.PersonID),
                new SqlParameter ("@FirstName", this.FirstName),
                new SqlParameter ("@LastName", this.LastName),
                new SqlParameter ("@DateOfBirth", this.DateOfBirth),
                new SqlParameter ("@Gendor", this.Gendor),
                new SqlParameter ("@Address", this.Address),
                new SqlParameter ("@ContactID", this.ContactID),
                new SqlParameter ("@CountryID", this.CountryID)
            };
            return clsPeopleData.UpdatePerson( Parameter );
        }
        public static bool IsPersonExists( int? PersonID )
        {
            SqlParameter Parameter = new SqlParameter();
            Parameter.ParameterName = "@PersonID";
            Parameter.Value = PersonID;
            return clsPeopleData.IsPersonExist( Parameter );
        }

        public static bool Delete( int? PersonID )
        {
            SqlParameter Parameter = new SqlParameter();
            Parameter.ParameterName = "@PersonID";
            Parameter.Value = PersonID;
            return clsPeopleData.DeletePerson( Parameter );
        }
        public bool Delete()
        {
            SqlParameter Parameter = new SqlParameter();
            Parameter.ParameterName = "@PersonID";
            Parameter.Value = this.PersonID;
            return clsPeopleData.DeletePerson( Parameter );
        }
        public bool Save()
        {

            switch ( _Mode )
            {
                case _enMode.ADD:
                    if ( _AddNewPerson() )
                    {
                        _Mode = _enMode.UPDATE;
                        return true;
                    }
                    else
                        return false;

                case _enMode.UPDATE:
                    return _UpdatePerson();
            }
            return false;
        }
    }
}
