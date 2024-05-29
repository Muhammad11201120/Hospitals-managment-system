using HMS_DataBusinessLayer;
using Hospital_Managment_System.Empolyee.Doctor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Managment_System
{
    public partial class ctrlFindDoctor : UserControl
    {
        public event Action<int> OnDoctorSelected;
        protected virtual void EmployeeSelected(int EmployeeID)
        {
            Action<int> handler = OnDoctorSelected;
            if (handler != null)
            {
                handler(EmployeeID);
            }
        }
        private bool _ShowAddDoctor = true;
        public bool ShowAddDoctor
        {
            get
            {
                return _ShowAddDoctor;
            }
            set
            {
                _ShowAddDoctor = value;
                btnAddNewDoctor.Visible = _ShowAddDoctor;
            }
        }
        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }
        public int? EmployeeID
        {
            get { return ctrlEmployeeCard1.EmployeeID; }
        }
       
        public clsEmployee SelectedEmployeeInfo
        {
            get { return ctrlEmployeeCard1.SelectedEmployeeInfo; }
        }

        clsDoctor _Doctor;
        public clsDoctor SelectedDoctorInfo
        {
            get { return _Doctor; }
        }


        public ctrlFindDoctor()
        {
            InitializeComponent();
        }
        private void _ResetDefaultValues()
        {
            lblDoctorID.Text = string.Empty;
            lblDoctorPrice.Text = string.Empty;
            lblSpecialty.Text = string.Empty;   
        }

        private void _Load()
        {
            lblDoctorID.Text = _Doctor.DoctorID.ToString();
            lblDoctorPrice.Text = _Doctor.Price.ToString();
            lblSpecialty.Text = _Doctor.Specialty.SpecialityName;

            ctrlEmployeeCard1.LoadEmployeeInfo(_Doctor.EmployeeID);
        }

        public void LoadDoctorInfo(int? DoctorID)
        {
            _ResetDefaultValues();
            _Doctor = clsDoctor.Find(DoctorID);
            if (_Doctor == null)
            {
                MessageBox.Show("No Doctor with Doctor ID = " +
                    DoctorID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _Load();
        }

        public void LoadDoctorInfoByDoctorID(int? EmployeeID)
        {
            _ResetDefaultValues();
            _Doctor = clsDoctor.FindByEmployeeID(EmployeeID);
            if (_Doctor == null)
            {
                MessageBox.Show("No Doctor with Employee ID = " +
                    EmployeeID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _Load();
        }



        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }
       
        private void _FindNow()
        {
            if (txtFilterValue.Text == "")
                return;
            switch (cbFilterBy.Text)
            {
                case "Doctor ID":
                    {
                        LoadDoctorInfo(int.Parse(txtFilterValue.Text));
                    }
                    break;

                case "Employee ID":
                    {
                        LoadDoctorInfoByDoctorID(int.Parse(txtFilterValue.Text));
                    }
                    break;
            }
            if (OnDoctorSelected != null && FilterEnabled && SelectedEmployeeInfo != null)
                OnDoctorSelected(ctrlEmployeeCard1.EmployeeID.Value);
        }
       
        private void DataBack(object sender, int EmployeeID)
        {
            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = EmployeeID.ToString();
            LoadDoctorInfo(EmployeeID);
        }
       
        private void btnAddNewDoctor_Click(object sender, EventArgs e)
        {
            frmAddUpdateDoctor frmAddUpdateEmpolyee = new frmAddUpdateDoctor();
            frmAddUpdateEmpolyee.DataBack += DataBack;
            frmAddUpdateEmpolyee.ShowDialog();
        }

        private void cbFilterBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "");
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            _FindNow();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnFind.PerformClick();
            }
            if (cbFilterBy.Text == "Employee ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (cbFilterBy.Text == "Doctor ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
