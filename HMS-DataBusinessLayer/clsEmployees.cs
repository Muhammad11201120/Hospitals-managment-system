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
    public class clsEmployees : clsPerson
    {
        enum _enMode
        {
            ADD = 1,
            UPDATE = 2
        }
        public int EmployeeID { get; set; }
        public decimal Salary { get; set; }
        _enMode _Mode = _enMode.ADD;
        public clsEmployees()
        {
            EmployeeID = -1;
            Salary = 0;
            _Mode = _enMode.ADD;
        }
        public clsEmployees( int employeeID, decimal salary, int personID, string firstName, string lastName, DateTime dateOfBirth, short gendor, string address, int contactID, int countryID )
            : base( personID, firstName, lastName, dateOfBirth, gendor, address, contactID, countryID )
        {
            EmployeeID = employeeID;
            Salary = salary;
            _Mode = _enMode.UPDATE;
        }
        public static DataTable GetAllEmployees()
        {
            return clsEmployeesData.GetAllEmpolyee();
        }
        public static clsEmployees Find( int EmployeeID )
        {
            decimal salary = 0;
            if ( clsEmployeesData.Find( EmployeeID ) )
            {

            }
        }
        private bool _AddNewEmployee()
        {
            int? employeeID = clsEmployeesData.AddNew( base.PersonID, this.Salary );
            return employeeID.HasValue;
        }
        private bool _UpdateEmployee()
        {
            return clsEmployeesData.Update( this.EmployeeID, base.PersonID, this.Salary );
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
