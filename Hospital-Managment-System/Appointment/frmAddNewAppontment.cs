using HMS_DataBusinessLayer;
using Hospital_Managment_System.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Hospital_Managment_System.Appointment
{
    public partial class frmAddNewAppontment : Form
    {
        clsAppointments _Appointment;
        int? _appointmentID;
        private DataTable _dtUnAvailableAppointments;
        private bool _IsAppointmentSelected = false;
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
            lblTitle.Text = "Add New Appointment";
            _Appointment = new clsAppointments();
            lblAppontmentID.Text = string.Empty;
            dtpAppontmentDate.MinDate = DateTime.Now;
            dtpAppontmentDate.MaxDate = DateTime.Now.AddDays(30);
            lblPrice.Text = "0";
            DateTime k = DateTime.Now;
            string x = "";
            x = k.ToString("");
            cbDoctors.Items.Clear();
            cbDoctors.Enabled = false;
            cbSpecialty.Enabled = false;
            lblAppontmentID.Enabled = false;
            lblPrice.Enabled = false;
            btnSave.Enabled = false;
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
            lblTitle.Text = "Update Appointment";
            ctrlPatientInfoWithFilter1.LoadData(_Appointment.PatientID);
            cbSpecialty.SelectedIndex = cbSpecialty.FindString(clsSpecialties.Find(_Appointment.DoctorInfo.SpecialtyID).SpecialityName);
            string FirstName = clsDoctor.Find(_Appointment.DoctorID).EmployeeInfo.FirstName;
            string LastName = clsDoctor.Find(_Appointment.DoctorID).EmployeeInfo.LastName;
            string FullName = FirstName + " " + LastName;
            txtAppointmentDate.Text = _Appointment.AppointmentDateTime.ToString("yyyy/M/dd : HH : mm");
            cbDoctors.SelectedIndex = cbDoctors.FindString(FullName);
            lblPrice.Text = _Appointment.TotalPrice.ToString();
            lblAppontmentID.Text = _Appointment.AppointmentID.ToString();
            lblPrice.Text = _Appointment.TotalPrice.ToString();
            cbDoctors.Enabled = true;
            cbSpecialty.Enabled = true;
            lblAppontmentID.Enabled = true;
            lblPrice.Enabled = true;
            btnSave.Enabled = true;
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

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Error: Data" +
                    " Is not Saved Successfully.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(clsAppointments.IsAppointmentExistByPatientIDAndDate(_Appointment.PatientID, (short)_Appointment.AppointmentDateTime.Year, (byte)_Appointment.AppointmentDateTime.Month, (byte)_Appointment.AppointmentDateTime.Day, (byte)_Appointment.AppointmentDateTime.Hour))
            {
                MessageBox.Show("You already have a reservation for this date, or you have a reservation with another doctor for this date."+_Appointment.AppointmentDateTime.ToString("yyyy/M/dd : HH : mm"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (clsAppointments.IsAppointmentExistByDoctorIDAndDate(_Appointment.DoctorID, (short)_Appointment.AppointmentDateTime.Year, (byte)_Appointment.AppointmentDateTime.Month, (byte)_Appointment.AppointmentDateTime.Day, (byte)_Appointment.AppointmentDateTime.Hour))
            {
                MessageBox.Show("This appointment is not available, please choose another appointment"+ _Appointment.AppointmentDateTime.ToString("yyyy/M/dd : HH : mm"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _Appointment.TotalPrice = decimal.Parse(lblPrice.Text);
            _Appointment.DoctorID = clsDoctor.FindDoctorByName(cbDoctors.SelectedItem.ToString()).DoctorID.Value;
            _Appointment.UserID = clsGlobal.CurrnetUser.UserID.Value;


            if (_Appointment.Save())
            {
                lblAppontmentID.Text = _Appointment.AppointmentID.ToString();

                _Mode = enMode.Update;
                _appointmentID = _Appointment.AppointmentID;
                MessageBox.Show("Data Saved Successfully.",
                    "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmAddNewAppontment_Load(null, null);
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
                MessageBox.Show("Please select a patient before continue", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            tcPatientInfo.SelectedIndex = 1;

            cbDoctors.Enabled = true;
            cbSpecialty.Enabled = true;
            lblAppontmentID.Enabled = true;
            lblPrice.Enabled = true;
            btnSave.Enabled = true;

        }
        private void cbSpecialty_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _FillComboBoxWithDoctora();
        }
        private void cbDoctors_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string DoctorName = cbDoctors.SelectedItem.ToString();
            lblPrice.Text = clsDoctor.FindDoctorByName(DoctorName).Price.ToString();
            _Appointment.DoctorID = clsDoctor.FindDoctorByName(cbDoctors.SelectedItem.ToString()).DoctorID.Value;
            dtpAppontmentDate_ValueChanged(null,null);
        }
        private void tcPatientInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctrlPatientInfoWithFilter1.PatientID == null && tcPatientInfo.SelectedIndex == 1)
            {
                MessageBox.Show("Please select a patient before continue", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

        }
        private void rbSelectDate_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton Temp = (RadioButton)sender;
            _Appointment.AppointmentDateTime = DateTime.Parse(dtpAppontmentDate.Value.ToString("d") + " " + Temp.Text);
            txtAppointmentDate.Text = _Appointment.AppointmentDateTime.ToString("yyyy/M/dd : HH : mm");
        }
        private void ShowAvailableAppointments(DataTable dtUnAvailableAppointments)
        {
            List<RadioButton> radioButtons = new List<RadioButton>();
            for (int i = 7; i <= 18; i++)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.CheckedChanged += rbSelectDate_CheckedChanged;
                radioButton.Text = i.ToString() + ":00";
                flpAvailableAppointments.Controls.Add(radioButton);
            }
            if (dtUnAvailableAppointments.Rows.Count == 0)
                return;
            for (int i = 0; i < flpAvailableAppointments.Controls.Count; i++)
            {
                foreach (DataRow row in dtUnAvailableAppointments.Rows)
                {
                    if (row[0].ToString() + ":00" == flpAvailableAppointments.Controls[i].Text.Trim())
                    {
                        flpAvailableAppointments.Controls.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }
        }
        private void dtpAppontmentDate_ValueChanged(object sender, EventArgs e)
        {
            if (cbDoctors.Text == "")
                return;
            flpAvailableAppointments.Controls.Clear();
            short Year = (short)dtpAppontmentDate.Value.Year;
            byte Month = (byte)dtpAppontmentDate.Value.Month;
            byte Day = (byte)dtpAppontmentDate.Value.Day;
            _dtUnAvailableAppointments = clsAppointments.GetAllAppointmentsHourByDoctorAndDate(_Appointment.DoctorID, Year, Month, Day);
            ShowAvailableAppointments(_dtUnAvailableAppointments);
        }
        private void txtAppointmentDate_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtAppointmentDate.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(flpAvailableAppointments, "Choose the date");
            }
            else
                errorProvider1.SetError(flpAvailableAppointments, null);
        }
    }
}
