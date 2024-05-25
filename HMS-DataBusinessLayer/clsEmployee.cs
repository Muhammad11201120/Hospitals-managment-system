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
    public class clsEmployee : clsPerson
    {
        enum _enMode
        {
            ADD = 1,
            UPDATE = 2
        }
        public int? EmployeeID { get; set; }
        public decimal? Salary { get; set; }
        public new int? PersonID { get; set; }
        _enMode _Mode = _enMode.ADD;
        public clsEmployee()
        {
            EmployeeID = null;
            Salary = null;
            _Mode = _enMode.ADD;
        }
        public clsEmployee( int? employeeID, decimal? salary, int? personID, string nationalNo, string firstName, string lastName, DateTime dateOfBirth, byte? gender, string address, int? contactID, int? countryID )

        {
            EmployeeID = employeeID;
            Salary = salary;
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
        public static DataTable GetAllEmployees()
        {
            return clsEmployeesData.GetAllEmpolyee();
        }

        public static new clsEmployee Find( int? EmployeeID )
        {

            SqlParameter[] parameters = new SqlParameter[ 3 ];
            parameters[ 0 ] = new SqlParameter( "EmployeeID", EmployeeID );
            parameters[ 1 ] = new SqlParameter( "PersonID", null );
            parameters[ 2 ] = new SqlParameter( "Salary", null );


            bool isFound = clsEmployeesData.FindEmpolyee( ref parameters );
            if ( isFound )
            {
                clsPerson person = clsPerson.Find( ( int ) parameters[ 1 ].Value );
                return new clsEmployee( ( int ) parameters[ 0 ].Value, ( decimal ) parameters[ 2 ].Value, person.PersonID, person.NationalNo, person.FirstName, person.LastName, person.DateOfBirth, person.Gender, person.Address, person.ContactID, person.ContactID );
            }
            else
                return null;

        }
        private bool _AddNewEmployee()
        {
            SqlParameter[] parameters = new SqlParameter[ 2 ];
            parameters[ 0 ] = new SqlParameter( "PersonID", this.PersonID );
            parameters[ 1 ] = new SqlParameter( "Salary", this.Salary );
            this.EmployeeID = clsEmployeesData.AddNewEmpolyee( parameters );
            return this.EmployeeID != null;
        }
        private bool _UpdateEmployee()
        {
            SqlParameter[] parameters = new SqlParameter[ 3 ];
            parameters[ 0 ] = new SqlParameter( "EmployeeID", this.EmployeeID );
            parameters[ 1 ] = new SqlParameter( "PersonID", this.PersonID );
            parameters[ 2 ] = new SqlParameter( "Salary", this.Salary );
            return clsEmployeesData.UpdateEmpolyee( parameters );
        }
        public bool DeleteEmployee()
        {
            SqlParameter parameter = new SqlParameter( "EmployeeID", this.EmployeeID );
            if ( clsEmployeesData.DeleteEmpolyee( parameter ) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool DeleteEmployee( int? EmployeeID )
        {
            SqlParameter parameter = new SqlParameter( "EmployeeID", EmployeeID );
            if ( clsEmployeesData.DeleteEmpolyee( parameter ) )
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
            bool result = false;
            switch ( _Mode )
            {
                case _enMode.ADD:
                    if ( _AddNewEmployee() )
                    {
                        _Mode = _enMode.UPDATE;
                        return true;
                    }
                    else
                        return false;
                case _enMode.UPDATE:
                    return _UpdateEmployee();

            }
            return result;
        }
    }
}
