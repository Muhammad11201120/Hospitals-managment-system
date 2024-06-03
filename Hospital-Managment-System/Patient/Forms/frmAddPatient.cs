using HMS_DataBusinessLayer;
using Hospital_Managment_System.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Managment_System.Appointment
{
    public partial class frmAddPatient : Form
    {
        public delegate void HandledEventHandler(object sender, int EmployeeID);
        public event HandledEventHandler DataBack;
        enum enMode { AddNew = 0, Update = 1 };

        enMode _Mode = enMode.AddNew;
        public enum enGendor { Male = 0, Female = 1 };

        clsPatient _Patient;

        int? _PatientID;
        public frmAddPatient()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddPatient(int? PatientID)
        {
            InitializeComponent();

            _PatientID = PatientID;

            _Mode = enMode.Update;

        }

        void _FillComboBoxWithCountry()
        {
            DataTable dt = clsCountries.GetAllCountries();

            foreach (DataRow row in dt.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
        }

        void _ResetDefaultValues()
        {
            _FillComboBoxWithCountry();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Patient";
                _Patient = new clsPatient();
            }
            else
            {
                lblTitle.Text = "Update Patient";
            }

            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtNationalNo.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;

            cbCountry.SelectedIndex = cbCountry.FindString("Saudi Arabia");

            rbMale.Checked = true;
            rbFemale.Checked = false;

            dtpDateOfBirth.Value = DateTime.Now;

        }

        void _LoadData()
        {
            _Patient = clsPatient.FindPatientByPatientID(_PatientID);

            if (_Patient == null)
            {
                MessageBox.Show("No Patient with ID = " +
                    _PatientID, "Patient Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblPatientID.Text = _PatientID.ToString();
            txtFirstName.Text = _Patient.FirstName;
            txtLastName.Text = _Patient.LastName;
            txtNationalNo.Text = _Patient.NationalNo;
            txtPhone.Text = _Patient.ContactInfo.PhoneNumber;
            txtEmail.Text = _Patient.ContactInfo.Email;
            txtAddress.Text = _Patient.Address;

            cbCountry.SelectedIndex = cbCountry.FindString(_Patient.CountryInfo.CountryName);

            dtpDateOfBirth.Value = _Patient.DateOfBirth;


            if (_Patient.Gender == 0)
            {
                rbMale.Checked = true;
                rbFemale.Checked = false;
            }
            else
            {
                rbMale.Checked = false;
                rbFemale.Checked = true;
            }
        }

        private void frmAddPatient_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        bool _CreateConactInfo()
        {
            clsContact contact = new clsContact();

            if (_Mode == enMode.AddNew)
                contact = new clsContact();
            else
                contact = clsContact.Find(_Patient.ContactID);

            contact.Email = txtEmail.Text;
            contact.PhoneNumber = txtPhone.Text;

            if (contact.Save())
            {
                _Patient.ContactID = contact.ContactID;
                return true;
            }
            else
                return false;

        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }

            if (_Mode != enMode.Update &&
                clsEmployee.IsPersonExists(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "National Number is used for another person!");

            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim() == string.Empty)
                return;

            if (!clsValidatoin.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_CreateConactInfo() || !this.ValidateChildren())
            {
                MessageBox.Show("Error: Data" +
                    " Is not Saved Successfully.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int? CountryID = clsCountries.Find(cbCountry.Text).CountryID;

            _Patient.FirstName = txtFirstName.Text;
            _Patient.LastName = txtLastName.Text;
            _Patient.NationalNo = txtNationalNo.Text;
            _Patient.DateOfBirth = dtpDateOfBirth.Value;
            _Patient.CountryID = CountryID;
            _Patient.Address = txtAddress.Text;

            if (rbMale.Checked)
                _Patient.Gender = (byte)enGendor.Male;
            else
                _Patient.Gender = (byte)enGendor.Female;


            if (_Patient.Save())
            {
                lblPatientID.Text = _Patient.PatientID.ToString();

                DataBack?.Invoke(this, _Patient.PatientID.Value);

                MessageBox.Show("Data Saved Successfully.",
                    "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data" +
                 " Is not Saved Successfully.",
                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


