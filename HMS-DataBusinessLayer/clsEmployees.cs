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
    public clsEmployees(int employeeID, decimal salary, int personID, string firstName, string lastName, DateTime dateOfBirth, short gendor, string address, int contactID, int countryID)
        : base(personID, firstName, lastName, dateOfBirth, gendor, address, contactID, countryID)
    {
      EmployeeID = employeeID;
      Salary = salary;
      _Mode = _enMode.UPDATE;
    }
    public static DataTable GetAllEmployees()
    {
      return clsEmployeesData.GetAllEmpolyee();
    }
    public new clsEmployees Find(int EmployeeID)
    {
      decimal salary = 0;
      clsPerson person = clsPerson.Find(base.PersonID);
      if (person != null)
      {
        SqlParameter[] parameters = new SqlParameter[2];
        parameters[0] = new SqlParameter("EmployeeID", EmployeeID);
        parameters[1] = new SqlParameter("Salary", salary);

        if (clsEmployeesData.FindEmpolyee(ref parameters))
        {
          return new clsEmployees(EmployeeID, salary, person.PersonID, person.FirstName, person.LastName, person.DateOfBirth, person.Gendor, person.Address, person.ContactID, person.ContactID);
        }
        else
          return null;
      }
      return null;
    }
    private bool _AddNewEmployee()
    {
      SqlParameter[] parameters = new SqlParameter[2];
      parameters[0] = new SqlParameter("PersonID", base.PersonID);
      parameters[1] = new SqlParameter("Salary", this.Salary);
      int? employeeID = clsEmployeesData.AddNewEmpolyee(parameters);
      return employeeID.HasValue;
    }
    private bool _UpdateEmployee()
    {
      SqlParameter[] parameters = new SqlParameter[3];
      parameters[0] = new SqlParameter("EmployeeID", this.EmployeeID);
      parameters[1] = new SqlParameter("PersonID", base.PersonID);
      parameters[2] = new SqlParameter("Salary", this.Salary);
      return clsEmployeesData.UpdateEmpolyee(parameters);
    }
    public bool Delete()
    {
      SqlParameter parameter = new SqlParameter("EmployeeID", this.EmployeeID);
      if (clsEmployeesData.DeleteEmpolyee(parameter))
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
      switch (_Mode)
      {
        case _enMode.ADD:
          if (_AddNewEmployee())
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
