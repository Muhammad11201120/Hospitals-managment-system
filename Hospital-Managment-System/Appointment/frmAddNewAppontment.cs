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
        clsAppointments _Appointment;
        int? _appointmentID;
        enum enMode { AddNew = 0, Update = 1 };

        enMode _Mode = enMode.AddNew;

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

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Appointment";
                _Appointment = new clsAppointments();
            }
            else
            {
                lblTitle.Text = "Update Appointment";
            }

            lblAppontmentID.Text = string.Empty; 
            dtpAppontmentDate.Value = DateTime.Now;
            lblPrice.Text  = "0";

            cbDoctors.Items.Clear ();

        }

        void _LoadData()
        {
            _Appointment = clsAppointments.FindByAppointmentID(_appointmentID);

            if (_Appointment == null)
            {
                MessageBox.Show("No appointment with ID = " +
                    _appointmentID, "Patient Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            ctrlPatientInfoWithFilter1.LoadData(_Appointment.PatientID);

            cbSpecialty.SelectedIndex = cbSpecialty.FindString(clsSpecialties.Find(_Appointment.DoctorInfo.SpecialtyID).SpecialityName);

            string FirstName = clsDoctor.Find(_Appointment.DoctorID).EmployeeInfo.FirstName;
            string LastName = clsDoctor.Find(_Appointment.DoctorID).EmployeeInfo.LastName;
            string FullName = FirstName + " " + LastName;

            cbDoctors.SelectedIndex =  cbDoctors.FindString(FullName);
            dtpAppontmentDate.Value = _Appointment.AppointmentDateTime;
            lblPrice.Text = _Appointment.TotalPrice.ToString();
            lblAppontmentID.Text = _Appointment.AppointmentID.ToString();
            lblPrice.Text = _Appointment.TotalPrice.ToString();
        }

        private void frmAddNewAppontment_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadData();
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

      

        private void btnSave_Click(object sender, EventArgs e)
        {

            if ( !this.ValidateChildren())
            {
                MessageBox.Show("Error: Data" +
                    " Is not Saved Successfully.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Appointment.TotalPrice = decimal.Parse( lblPrice.Text);
            _Appointment.AppointmentDateTime = dtpAppontmentDate.Value;
            _Appointment.DoctorID = clsDoctor.FindDoctorByName(cbDoctors.SelectedItem.ToString()).DoctorID.Value;
            _Appointment.UserID = clsGlobal.CurrnetUser.UserID.Value;


            if (_Appointment.Save())
            {
                lblAppontmentID.Text = _Appointment.AppointmentID.ToString();

                _Mode = enMode.Update;
                lblTitle.Text = "Update Appointment";

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

        private void ctrlPatientInfoWithFilter1_OnPatientSelected(int obj)
        {
            _Appointment.PatientID = obj;
        }

        private void btnDoctorInfoNext_Click(object sender, EventArgs e)
        {
            if (ctrlPatientInfoWithFilter1.PatientID == null)
            {
                MessageBox.Show("Please select a patient before continue","Error" , MessageBoxButtons.OK,
                    MessageBoxIcon.Error );
                return;
            }

            tcPatientInfo.SelectedIndex = 1;
        }

        private void cbSpecialty_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _FillComboBoxWithDoctora();
        }

        private void cbDoctors_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string DoctorName = cbDoctors.SelectedItem.ToString();

            lblPrice.Text = clsDoctor.FindDoctorByName(DoctorName).Price.ToString();
        }
    }
}
