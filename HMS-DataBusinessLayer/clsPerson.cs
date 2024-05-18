using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataBusinessLayer
{
    public class clsPerson
    {
        enum _enMode
        {
            ADD = 0,
            UPDATE = 1
        }
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gendor { get; set; }
        public string Address { get; set; }
        public int ContactID { get; set; }
        public int CountryID { get; set; }
        private _enMode _Mode = _enMode.ADD;
        public clsPerson()
        {
            PersonID = -1;
            FirstName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = DateTime.Now;
            Gendor = -1;
            Address = string.Empty;
            ContactID = -1;
            CountryID = -1;
            _Mode = _enMode.ADD;
        }
        public clsPerson( int personID, string firstName, string lastName, DateTime dateOfBirth, int gendor, string address, int contactID, int countryID )
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
    }
}
