using HMS_BusinessLayer;
using HMS_DataBusinessLayer;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Managment_System.Global
{
    public class clsGlobal
    {
        public static clsHospitalInfo CurrentHospital;

        public static clsUser CurrnetUser = clsUser.Find(6);

    }
}
