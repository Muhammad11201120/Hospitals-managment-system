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

namespace Hospital_Managment_System.Appointment
{
    public partial class ctrlPatient : UserControl
    {
        public ctrlPatient()
        {
            InitializeComponent();
        }

        private int? _PatientID;
        private clsPatient _Patient;
        public int? PatientID
        {
            get { return _PatientID; }
        }
        public clsPatient SelectedPatientInfo
        {
            get { return _Patient; }
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
       
        private void ResetDefaultValues()
        {
            lblPatientID.Text    = "N/A" ;
            lblAddress.Text      = "N/A" ;
            lblCountry.Text      = "N/A" ;
            lblDateOfBirth.Text  = "N/A" ;
            lblEmail.Text        = "N/A" ;
            lblPatientID.Text    = "N/A" ;
            lblName.Text         = "N/A" ;
            lblNationalNo.Text   = "N/A" ;
            lblPhone.Text        = "N/A" ;
            rbGendor.Text = "N/A";
        }
        private void _LoadPatientInfo()
        {
            lblPatientID.Text = _Patient.PatientID.ToString();
            lblName.Text = _Patient.FirstName + " " + _Patient.LastName;
            lblNationalNo.Text = _Patient.NationalNo;
            lblPhone.Text = _Patient.ContactInfo.PhoneNumber;
            lblEmail.Text = _Patient.ContactInfo.Email;
            lblAddress.Text = _Patient.Address;
            lblCountry.Text = clsCountries.Find(_Patient.CountryID).CountryName;
            lblDateOfBirth.Text = _Patient.DateOfBirth.ToString("d");
            _PatientID = _Patient.PatientID;

            if (_Patient.Gender == 1)
            {
                rbGendor.Text = "Male";
            }
            else
            {
                rbGendor.Text = "Female";
            }
        }
        public void LoadPatientInfo(int? PatientID)
        {
            ResetDefaultValues();

            _Patient = clsPatient.FindPatientByPatientID(PatientID);

            if (_Patient == null)
            {
                MessageBox.Show("No Patient with PatientID = " +
                    PatientID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LoadPatientInfo();
        }

        private void llEdit_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_Patient == null)
            {
                MessageBox.Show("Please Select a person before contuine", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmAddPatient frmAddUpdatePatient = new frmAddPatient(_PatientID);
            frmAddUpdatePatient.ShowDialog();
            LoadPatientInfo(PatientID.Value);
        }
    }
}
