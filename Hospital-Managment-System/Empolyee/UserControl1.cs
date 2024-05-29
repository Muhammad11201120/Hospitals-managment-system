using HMS_DataBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Managment_System.Empolyee
{
    public partial class UserControl1 : UserControl
    {
        clsDoctor _Doctor;
        public UserControl1()
        {
            InitializeComponent();
        }
        private void _ResetDefaultValues()
        {
            lblDoctorID.Text = string.Empty;
            lblDoctorPrice.Text = string.Empty;
        }

        private void _LoadDoctorInfo()
        {
            lblDoctorID.Text = _Doctor.DoctorID.ToString();
            lblDoctorPrice.Text = _Doctor.Price.ToString();
        }

        private void ctrlEmployeeCardWithFilter1_OnEmployeeSelected(int EmployeeID)
        {
            _ResetDefaultValues();
            _Doctor = clsDoctor.FindByEmployeeID(EmployeeID);
            if (_Doctor == null)
            {
                MessageBox.Show("No Doctor with EmployeeID = "
                    + EmployeeID.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LoadDoctorInfo();
        }

    }
}

