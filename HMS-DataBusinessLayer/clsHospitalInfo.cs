using HMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataBusinessLayer
{
    public class clsHospitalInfo
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode;

        public Nullable<int> ID { get; set; }
        public string HospitalName { get; set; }
        public string HospitalPhone { get; set; }
        public string HospitalLogo { get; set; }
        public string HospitalAddress { get; set; }

        public clsHospitalInfos()
        {
            this.ID = default(int);
            this.HospitalName = default(string);
            this.HospitalPhone = default(string);
            this.HospitalLogo = default(string);
            this.HospitalAddress = default(string);

            this.Mode = enMode.AddNew;
        }

        private clsHospitalInfo(int id, string hospitalname, string hospitalphone, string hospitallogo, string hospitaladdress)
        {
            this.ID = id;
            this.HospitalName = hospitalname;
            this.HospitalPhone = hospitalphone;
            this.HospitalLogo = hospitallogo;
            this.HospitalAddress = hospitaladdress;

            this.Mode = enMode.Update;
        }

        private bool _AddNewHospitalInfos()
        {
            // parameters
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("HospitalName", this.HospitalName);
            parameters[1] = new SqlParameter("HospitalPhone", this.HospitalPhone);
            parameters[2] = new SqlParameter("HospitalLogo", this.HospitalLogo);
            parameters[3] = new SqlParameter("HospitalAddress", this.HospitalAddress);

            this.ID = HospitalInfoData.AddNew(parameters);

            return (this.ID != null);
        }

        private bool _UpdateHospitalInfos()
        {
            // parameters
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("ID", this.ID);
            parameters[1] = new SqlParameter("HospitalName", this.HospitalName);
            parameters[2] = new SqlParameter("HospitalPhone", this.HospitalPhone);
            parameters[3] = new SqlParameter("HospitalLogo", this.HospitalLogo);
            parameters[4] = new SqlParameter("HospitalAddress", this.HospitalAddress);

            return HospitalInfoData.Update( parameters);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewHospitalInfos())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateHospitalInfos();

            }
            return false;
        }

        public static clsHospitalInfo FindByID(int ID)
        {
            // parameters
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("ID", ID);
            parameters[1] = new SqlParameter("HospitalName", null);
            parameters[2] = new SqlParameter("HospitalPhone", null);
            parameters[3] = new SqlParameter("HospitalLogo", null);
            parameters[4] = new SqlParameter("HospitalAddress", null);

            if (HospitalInfoData.Find(ref parameters))
            {
                return new clsHospitalInfo((int)parameters[0].Value, (string)parameters[1].Value, (string)parameters[2].Value, (string)parameters[3].Value, (string)parameters[4].Value);
            }
            else
                return null;

        }

        public static bool IsExist(int ID)
        {
            SqlParameter parameter = new SqlParameter("ID", ID);

            return HospitalInfoData.IsHospitalExist(parameter);
        }

        public static bool Delete(int ID)
        {
            SqlParameter parameter = new SqlParameter("ID", ID);

            return HospitalInfoData.Delete(parameter);
        }

    }
}
