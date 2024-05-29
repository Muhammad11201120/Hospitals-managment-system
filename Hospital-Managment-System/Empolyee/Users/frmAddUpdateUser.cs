using System;
using System.Windows.Forms;

namespace Hospital_Managment_System.Empolyee.Users
{
    public partial class frmAddUpdateUser : Form
    {
        private enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode;

        private int? _EmpID;
        private int? _UserID;


        public frmAddUpdateUser(int? EmpID)
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
            _EmpID = EmpID;
        }

        public frmAddUpdateUser(int? EmpID, int UserID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _EmpID = EmpID;
            _UserID = UserID;
        }

    }
}
