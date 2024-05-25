using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_DataAccessLayer;

namespace HMS_DataBusinessLayer
{
    public class clsSpecialties
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode;
        private int? _SpecialityID;
        public int? SpecialityID { get { return _SpecialityID; } }
        public string SpecialityName { set;get; }
        public clsSpecialties()
        {
            this._SpecialityID = null;
            this.SpecialityName=string.Empty;
            Mode = enMode.AddNew;
        }
        private clsSpecialties(int specialityID, string specialityName)
        {
            _SpecialityID = specialityID;
            SpecialityName = specialityName;
            this.Mode= enMode.Update;
        }
        private bool _AddNewSpeciality()
        {
            SqlParameter sp =  new SqlParameter("SpecialityName", this.SpecialityName);
            // return this._SpecialityID != clsSpecialityData.AddNew(sp);
            return false;
        }
        private bool _UpdateSpeciality()
        {
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("SpecialityID", this._SpecialityID);
            sp[1] = new SqlParameter("SpecialityName", this.SpecialityName);
            //return clsSpecialityData.Update(sp);
            return false;
        }
        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if(_AddNewSpeciality())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateSpeciality();
                default:
                    return false;
            }
        }
        public static clsSpecialties Find(int SpecialityID)
        {
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("SpecialityID", SpecialityID);
            sp[1] = new SqlParameter("SpecialityName",null);
            bool IsFind = false;
            if (IsFind)
                return new clsSpecialties((int)sp[0].Value, (string)sp[1].Value);
            else
                return null;
        }
        public static bool IsSpecialityExist(int SpecialityID)
        {
            SqlParameter sp = new SqlParameter("SpecialityID", SpecialityID);
            return true;
        }
        public static DataTable GetAllSpecialties()
        {
            return clsSpecialityData.GetAllSpecialties();
        }
        public static bool DeleteSpeciality(int PaymentID)
        {
            return clsSpecialityData.Delete(PaymentID);
        }
    }
}
