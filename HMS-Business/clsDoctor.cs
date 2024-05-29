using HMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HMS_DataBusinessLayer
{

    public class clsDoctor
    {
        enum _enMode
        {
            ADD = 1,
            UPDATE = 2
        }
        public int? DoctorID { get; set; }
        public int? EmployeeID { get; set; }
        public int? SpecialtyID { get; set; }
        public decimal? Price { get; set; }

        public clsSpecialties Specialty { get; set; }

        _enMode _Mode = _enMode.ADD;
        public clsDoctor()
        {
            DoctorID = null;
            EmployeeID = null;
            Price = null;
            SpecialtyID = null;
            _Mode = _enMode.ADD;
        }
        public clsDoctor(int? doctorID, int? employeeID,
            decimal? price, int? specialtyID)
        {
            DoctorID = doctorID;
            EmployeeID = employeeID;
            Price = price;
            SpecialtyID = specialtyID;
            Specialty = clsSpecialties.Find(specialtyID);
            _Mode = _enMode.UPDATE;
        }
        public static DataTable GetAllEmployees()
        {
            return clsDocotrsData.GetAllDoctors();
        }
        public static clsDoctor Find(int? doctorID)
        {
            int? employeeID = null, specialtyID = null;
            decimal? price = null;

            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("DoctorID", doctorID);
            parameters[1] = new SqlParameter("EmployeeID", employeeID);
            parameters[2] = new SqlParameter("Price", price);
            parameters[3] = new SqlParameter("SpecialtyID", specialtyID);


            if (clsDocotrsData.Find(ref parameters))
                return new clsDoctor((int)parameters[0].Value, (int)parameters[1].Value, (decimal)parameters[2].Value, (int)parameters[3].Value);
            else
                return null;

        }

        public static clsDoctor FindByEmployeeID(int? employeeID)
        {
            int? doctorID = null, specialtyID = null;
            decimal? price = null;

            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("EmployeeID", employeeID);
            parameters[1] = new SqlParameter("DoctorID", doctorID);
            parameters[2] = new SqlParameter("Price", price);
            parameters[3] = new SqlParameter("SpecialtyID", specialtyID);


            if (clsDocotrsData.FindByEmployeeID(ref parameters))
                return new clsDoctor((int)parameters[0].Value, (int)parameters[1].Value, (decimal)parameters[2].Value, (int)parameters[3].Value);
            else
                return null;

        }
        private bool _AddNewDoctor()
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("EmployeeID", this.EmployeeID);
            parameters[1] = new SqlParameter("Price", this.Price);
            parameters[2] = new SqlParameter("SpecialtyID", this.SpecialtyID);

            this.DoctorID = clsDocotrsData.AddNewDoctor(parameters);


            return DoctorID.HasValue;
        }
        private bool _UpdateDoctor()
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("DoctorID", this.DoctorID);
            parameters[1] = new SqlParameter("EmployeeID", this.EmployeeID);
            parameters[2] = new SqlParameter("Price", this.Price);
            parameters[3] = new SqlParameter("SpecialtyID", this.SpecialtyID);


            return clsDocotrsData.UpdateDoctor(parameters);

        }

        public bool Save()
        {

            switch (_Mode)
            {
                case _enMode.ADD:
                    if (_AddNewDoctor())
                    {
                        _Mode = _enMode.UPDATE;
                        return true;
                    }
                    else
                        return false;

                case _enMode.UPDATE:
                    return _UpdateDoctor();
            }
            return false;
        }
        public bool Delete(int? doctorID)
        {
            SqlParameter parameter = new SqlParameter("DoctorID", doctorID);

            if (clsDocotrsData.DeleteDoctor(parameter))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool isDoctorExistForEmployeeID(int EmployeeID)
        {
            SqlParameter sqlParameter = new SqlParameter("EmployeeID", EmployeeID);
            return clsDocotrsData.isDoctorExistForEmployeeID(sqlParameter);
        }
    }
}


