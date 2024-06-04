using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HMS_DataAccessLayer;
namespace HMS_DataBusinessLayer
{
    public class clsPerson
    {
        public enum enMode
        {
            ADD = 0,
            UPDATE = 1
        }
        public int? PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName()
        {
            return FirstName + " " + LastName;
        }
        public DateTime DateOfBirth { get; set; }
        public byte? Gender { get; set; }
        public string Address { get; set; }
        public int? ContactID { get; set; }
        public int? CountryID { get; set; }

        public enMode Mode = enMode.ADD;

        public clsContact ContactInfo
        {
            get
            {
                return clsContact.Find(ContactID);
            }
        }

        public clsCountries CountryInfo
        {
            get
            {
                return clsCountries.Find(CountryID);
            }
        }


        public clsPerson()
        {
            PersonID = null;
            NationalNo = null;
            FirstName = null;
            LastName = null;
            DateOfBirth = DateTime.Now;
            Gender = null;
            Address = null;
            ContactID = null;
            CountryID = null;
            Mode = enMode.ADD;
        }
        public clsPerson( int? personID, string nationalNo, string firstName, string lastName, DateTime dateOfBirth, byte? gender, string address, int? contactID, int? countryID )
        {
            PersonID = personID;
            NationalNo = nationalNo;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Address = address;
            ContactID = contactID;
            CountryID = countryID;
            Mode = enMode.UPDATE;
        }

        public static DataTable GetAllPeople()
        {
            return clsPeopleData.GetAllPeople();
        }

        public static clsPerson Find( int? PersonID )
        {

            SqlParameter[] Parameter = new SqlParameter[ 9 ];
            Parameter[ 0 ] = new SqlParameter( "PersonID", PersonID );
            Parameter[ 1 ] = new SqlParameter( "NationalNo", null );
            Parameter[ 2 ] = new SqlParameter( "FirstName", null );
            Parameter[ 3 ] = new SqlParameter( "LastName", null );
            Parameter[ 4 ] = new SqlParameter( "DateOfBirth", null );
            Parameter[ 5 ] = new SqlParameter( "Gender", null );
            Parameter[ 6 ] = new SqlParameter( "Address", null );
            Parameter[ 7 ] = new SqlParameter( "ContactID", null );
            Parameter[ 8 ] = new SqlParameter( "CountryID", null );

            bool isFound = clsPeopleData.GetPersonByID( ref Parameter );

            if ( isFound )

                return new clsPerson( ( int ) Parameter[ 0 ].Value, ( string ) Parameter[ 1 ].Value,
                    ( string ) Parameter[ 2 ].Value, ( string ) Parameter[ 3 ].Value, ( DateTime )
                    Parameter[ 4 ].Value, ( byte ) Parameter[ 5 ].Value, ( string ) Parameter[ 6 ].Value,
                    ( int ) Parameter[ 7 ].Value, ( int ) Parameter[ 8 ].Value );

            else
                return null;
        }

        private bool _AddNewPerson()
        {
            SqlParameter[] Parameter = new SqlParameter[]
            {
                new SqlParameter("NationaLNo", NationalNo),
                new SqlParameter ("FirstName",this.FirstName ),
                new SqlParameter ("LastName", this.LastName),
                new SqlParameter ("DateOfBirth", this.DateOfBirth),
                new SqlParameter ("Gender", this.Gender),
                new SqlParameter ("Address", this.Address),
                new SqlParameter ("ContactID", this.ContactID),
                new SqlParameter ("CountryID", this.CountryID)
            };
            this.PersonID = clsPeopleData.AddNewPerson( Parameter );
            return ( this.PersonID != null );
        }

        private bool _UpdatePerson()
        {
            SqlParameter[] Parameter = new SqlParameter[]
            {
                new SqlParameter ("PersonID", this.PersonID),
                new SqlParameter("NationaLNo", NationalNo),
                new SqlParameter ("FirstName", this.FirstName),
                new SqlParameter ("LastName", this.LastName),
                new SqlParameter ("DateOfBirth", this.DateOfBirth),
                new SqlParameter ("Gender", this.Gender),
                new SqlParameter ("Address", this.Address),
                new SqlParameter ("ContactID", this.ContactID),
                new SqlParameter ("CountryID", this.CountryID)
            };
            return clsPeopleData.UpdatePerson( Parameter );
        }
        public static bool IsPersonExists( int? PersonID )
        {
            SqlParameter Parameter = new SqlParameter();
            Parameter.ParameterName = "PersonID";
            Parameter.Value = PersonID;
            return clsPeopleData.IsPersonExist( Parameter );
        }

        public static bool IsPersonExists( string NationaLNo )
        {
            SqlParameter Parameter = new SqlParameter();
            Parameter.ParameterName = "NationaLNo";
            Parameter.Value = NationaLNo;

            return clsPeopleData.IsPersonExistByNationalNO( Parameter );
        }

        public static bool Delete( int? PersonID )
        {
            SqlParameter Parameter = new SqlParameter();
            Parameter.ParameterName = "PersonID";
            Parameter.Value = PersonID;
            return clsPeopleData.DeletePerson( Parameter );
        }

        public bool Save()
        {

            switch ( Mode )
            {
                case enMode.ADD:
                    if ( _AddNewPerson() )
                    {
                        Mode = enMode.UPDATE;
                        return true;
                    }
                    else
                        return false;

                case enMode.UPDATE:
                    return _UpdatePerson();
            }
            return false;
        }
    }
}
