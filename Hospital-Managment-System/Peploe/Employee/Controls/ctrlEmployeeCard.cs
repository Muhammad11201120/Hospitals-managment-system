using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS_DataBusinessLayer;
using Hospital_Managment_System.Properties;
namespace Hospital_Managment_System.Empolyee.EmployeeControls
{
    public partial class ctrlEmployeeCard : UserControl
    {        private int? _EmployeeID;
        private clsEmployee _Employee;
        public int? EmployeeID
        {
            get { return _EmployeeID; }
        }
        public clsEmployee SelectedEmployeeInfo
        {
            get { return _Employee; }
        }
        private bool _EditedVisible = true;
        public bool EditedVisible
        {
            get
            {
                return _EditedVisible;
            }
            set
            {
                _EditedVisible = value;
                llEdit.Visible = _EditedVisible;
            }
        }
        public ctrlEmployeeCard()
        {
            InitializeComponent();
        } 
        private void ResetDefaultValues()
        {
            lblAddress.Text = string.Empty;
            lblCountry.Text = string.Empty;
            lblDateOfBirth.Text = string.Empty;
            lblEmail.Text = string.Empty;
            lblEmpolyeeID.Text = string.Empty;
            lblName.Text = string.Empty;
            lblNationalNo.Text = string.Empty;
            lblPhone.Text = string.Empty;
            lblSalary.Text = string.Empty;
            rbGendor.Text = string.Empty;
            llEdit.Enabled = false;
        }
        private void _LoadEmployeeInfo()
        {
            lblEmpolyeeID.Text=_Employee.EmployeeID.ToString(); 
            lblName.Text = _Employee.FirstName + " " + _Employee.LastName;
            lblNationalNo.Text = _Employee.NationalNo;
            lblPhone.Text = _Employee.ContactInfo.PhoneNumber;
            lblEmail.Text = _Employee.ContactInfo.Email;
            lblAddress.Text = _Employee.Address;
            lblSalary.Text = _Employee.Salary.ToString();
            lblCountry.Text = clsCountries.Find(_Employee.CountryID).CountryName;
            lblDateOfBirth.Text = _Employee.DateOfBirth.ToString("d");
            _EmployeeID = _Employee.EmployeeID;
            llEdit.Enabled = true;
            if (_Employee.Gender == 1)
            {
                pbPersonImage.Image = Resources.Male_512;
                pbGendor.Image = Resources.Male_512;
                rbGendor.Text = "Male";
            }
            else
            {
                pbPersonImage.Image = Resources.Female_512;
                pbGendor.Image = Resources.Female_512; 
                rbGendor.Text = "Female";
            }
        }
        public void LoadEmployeeInfo(int? EmployeeID)
        {
            ResetDefaultValues();
            _Employee = clsEmployee.Find(EmployeeID);
            if( _Employee == null ) 
            {
                MessageBox.Show("No Employee with EmployeeID = " +
                    EmployeeID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LoadEmployeeInfo();
        }
        private void llEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateEmpolyee frmAddUpdateEmpolyee = new frmAddUpdateEmpolyee(_EmployeeID);
            frmAddUpdateEmpolyee.ShowDialog();
            LoadEmployeeInfo(EmployeeID.Value);
        }
    }
}
