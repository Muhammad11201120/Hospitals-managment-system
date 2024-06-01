using HMS_DataBusinessLayer;
using Hospital_Managment_System.Global;
using Hospital_Managment_System.Properties;
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
    public partial class frmAddNewAppontment : Form
    {
        clsAppointments appointment;
        int? _appointmentID;
        enum enMode { AddNew = 0, Update = 1 };
        public enum enGendor { Male = 0, Female = 1 };

        enMode _Mode = enMode.AddNew;

        clsPatient _Patient;


        public frmAddNewAppontment()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddNewAppontment(int? AppointmentID)
        {
            InitializeComponent();

            _appointmentID = AppointmentID;

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

        private void _FillSpecialtiesInComoboBox()
        {
            cbSpecialty.Items.Clear();
            foreach (DataRow row in clsSpecialties.GetAllSpecialties().Rows)
            {
                cbSpecialty.Items.Add(row["SpecialityName"]);
            }
        }
        void _ResetDefaultValues()
        {
            _FillSpecialtiesInComoboBox();
            _FillComboBoxWithCountry();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Appontment";
                appointment = new clsAppointments();
                _Patient = new clsPatient();
            }
            else
            {
                lblTitle.Text = "Update Appontment";
            }

            lblAppontmentID.Text = string.Empty; 
            dtpAppontmentDate.Value = DateTime.Now;
            lblPrice.Text  = string.Empty;

            cbDoctors.Items.Clear ();


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
            appointment = clsAppointments.FindByAppointmentID(_appointmentID);

            if (appointment == null)
            {
                MessageBox.Show("No appointment with ID = " +
                    _appointmentID, "Patient Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            cbSpecialty.SelectedIndex = cbSpecialty.FindString(clsSpecialties.Find(appointment.DoctorInfo.SpecialtyID).SpecialityName);

            string FirstName = clsDoctor.Find(appointment.DoctorID).EmployeeInfo.FirstName;
            string LastName = clsDoctor.Find(appointment.DoctorID).EmployeeInfo.LastName;
            string FullName = FirstName + " " + LastName;

            cbDoctors.SelectedIndex =  cbDoctors.FindString(FullName);
            dtpAppontmentDate.Value = appointment.AppointmentDateTime;
            lblPrice.Text = appointment.TotalPrice.ToString();
            lblAppontmentID.Text = appointment.AppointmentID.ToString();

            lblPatientID.Text = appointment.PatientID.ToString();
            txtFirstName.Text = appointment.PatientInfo.FirstName;
            txtLastName.Text = appointment.PatientInfo.LastName;
            txtNationalNo.Text = appointment.PatientInfo.NationalNo;
            txtPhone.Text = appointment.PatientInfo.ContactInfo.PhoneNumber;
            txtEmail.Text = appointment.PatientInfo.ContactInfo.Email;
            txtAddress.Text = appointment.PatientInfo.Address;

            cbCountry.SelectedIndex = cbCountry.FindString(appointment.PatientInfo.CountryInfo.CountryName);

            dtpDateOfBirth.Value = appointment.PatientInfo.DateOfBirth;


            if (appointment.PatientInfo.Gender == 0)
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

        private void frmAddNewAppontment_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        bool _CreateConactInfo()
        {
            clsContact contact = new clsContact();

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

        private void btnDoctorInfoNext_Click(object sender, EventArgs e)
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
                appointment.PatientID = _Patient.PatientID.Value;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void _FillComboBoxWithDoctora()
        {
            string SpecialityName = cbSpecialty.SelectedItem.ToString();

            DataTable dt = clsDoctor.GetAllDoctorsBySpeciality(SpecialityName);

            foreach (DataRow row in dt.Rows)
            {
                cbDoctors.Items.Add(row["Name"]);
            }
        }

        private void cbSpecialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FillComboBoxWithDoctora();


        }

        private void cbDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            string DoctorName = cbDoctors.SelectedItem.ToString();

            lblPrice.Text = clsDoctor.FindDoctorByName(DoctorName).Price.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if ( !this.ValidateChildren())
            {
                MessageBox.Show("Error: Data" +
                    " Is not Saved Successfully.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            appointment.TotalPrice = decimal.Parse( lblPrice.Text);
            appointment.AppointmentDateTime = dtpAppontmentDate.Value;
            appointment.DoctorID = clsDoctor.FindDoctorByName(cbDoctors.SelectedItem.ToString()).DoctorID.Value;
            appointment.UserID = clsGlobal.CurrnetUser.UserID.Value;


            if (appointment.Save())
            {
                lblAppontmentID.Text = appointment.AppointmentID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update appointments";

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

            if (txtNationalNo.Text.Trim() != _Patient.NationalNo &&
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
    }
}
