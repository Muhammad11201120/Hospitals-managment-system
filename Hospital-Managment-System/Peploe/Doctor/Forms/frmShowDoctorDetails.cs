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

namespace Hospital_Managment_System.Empolyee.Doctor.DoctorForms
{
    public partial class frmShowDoctorDetails : Form
    {
        private int? _DoctorID;
        private clsDoctor _Doctor;
        public frmShowDoctorDetails(int? DoctorID)
        {
            InitializeComponent();
            _DoctorID = DoctorID;
        }
        private void _LoadDoctorInfo()
        {
            if (!_DoctorID.HasValue)
            {
                MessageBox.Show("Data entry error", "Erroe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            _Doctor = clsDoctor.Find(_DoctorID);
            if( _Doctor != null ) 
            {
                ctrlEmployeeCard1.LoadEmployeeInfo(_Doctor.EmployeeID);
                lblDoctorID.Text=_DoctorID.ToString();
                lblDoctorPrice.Text=_Doctor.Price.ToString();
                lblSpecialty.Text =_Doctor.Specialty.SpecialityName;
            }

        }

        private void frmShowDoctorDetails_Load(object sender, EventArgs e)
        {
            _LoadDoctorInfo();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
