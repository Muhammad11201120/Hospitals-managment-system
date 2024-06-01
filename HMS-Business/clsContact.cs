using HMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataBusinessLayer
{
    public class clsContact
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public int? ContactID { private set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }

        public clsContact() 
        {
            this.ContactID =null; 
            this.Email = string.Empty;
            this.PhoneNumber = string.Empty;

            Mode = enMode.AddNew;
        }
        private clsContact (int? ContactID,string Email,string PhoneNumber)
        {
            this.ContactID=ContactID;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;

            Mode = enMode.Update;
        }

        private bool _AddNewContact()
        {
            SqlParameter[] parameter = new SqlParameter[2];
            parameter[0] = new SqlParameter("Email", this.Email);
            parameter[1] = new SqlParameter("PhoneNumber", this.PhoneNumber);
            this.ContactID = clsContactData.AddNewContact(parameter);
            return this.ContactID != null;
        }
        private bool _UpdateContact()
        {
            SqlParameter[] parameter = new SqlParameter[3];
            parameter[0] = new SqlParameter("ContactID", this.ContactID);
            parameter[1] = new SqlParameter("Email", this.Email);
            parameter[2] = new SqlParameter("PhoneNumber", this.PhoneNumber);
            return clsContactData.UpdateContact(parameter); 
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewContact())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateContact();

            }

            return false;
        }

        public static clsContact Find(int? ContactID)
        {
            SqlParameter[] parameter = new SqlParameter[3];
            parameter[0] = new SqlParameter("ContactID",ContactID);
            parameter[1] = new SqlParameter("Email",null);
            parameter[2] = new SqlParameter("PhoneNumber",null);
            bool isFond=clsContactData.GetContactByID(ref parameter);
            if(isFond)
                return new clsContact((int)parameter[0].Value, (string)parameter[1].Value,(string) parameter[2].Value);
            return null;
        }
        public static bool DeleteContact(int ContactID)
        {
            SqlParameter sp = new SqlParameter("ContactID", ContactID);
            return clsContactData.DeleteContact(sp);
        }
        public static bool IsContactExist(int ContactID)
        {
            SqlParameter sp = new SqlParameter("ContactID", ContactID);
            return clsContactData.IsContactExist(sp);
        }

    }
}
