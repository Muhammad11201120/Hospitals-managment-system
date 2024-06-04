using HMS_DataBusinessLayer;
using Hospital_Managment_System.Payment;
using System;
using System.Windows.Forms;

namespace Hospital_Managment_System.Appointment
{
    public partial class frmCompleteAppointment : Form
    {
        public frmCompleteAppointment(int appointmentID)
        {
            InitializeComponent();

            this._AppointmentID = appointmentID;
        }

        private int _AppointmentID { get; set; }
        private string PatientName
        {
            get
            {
                return clsPatient.FindPatientByPatientID(clsAppointments.FindByAppointmentID(_AppointmentID).PatientID).FullName();
            }
        }
        private string PatientNationalNo
        {
            get
            {
                return clsPatient.FindPatientByPatientID(clsAppointments.FindByAppointmentID(this._AppointmentID).PatientID).NationalNo;
            }
        }

        private void _FillInfo()
        {
            dtpEndDate.MinDate = DateTime.Now;
            dtpStartDate.MinDate = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            dtpStartDate.Value = DateTime.Now;

            lblAppointmentID.Text = _AppointmentID.ToString();
            lblPatientName.Text = PatientName;
            lblNationalNo.Text = PatientNationalNo;
        }

        private bool _CheckBeforeSave()
        {
            if (!_CheckNullOrEmpty(txtVisitDescription)) return false;

            if (!_CheckNullOrEmpty(txtDiagnosis)) return false;

            if (chkYes.Checked)
            {
                if (!_CheckNullOrEmpty(txtMedicationName)) return false;

                if (!_CheckNullOrEmpty(txtDosage)) return false;

                if (!_CheckNullOrEmpty(txtFrequency)) return false;
            }

            return true;
        }

        private bool _CheckNullOrEmpty(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider1.SetError(textBox, "this is required");
                return false;
            }
            else
                errorProvider1.SetError(textBox, "");

            return true;
        }

        private void chkYes_CheckedChanged(object sender, EventArgs e)
        {
            gbPrescription.Enabled = chkYes.Checked;
        }

        private void chkNo_CheckedChanged(object sender, EventArgs e)
        {
            gbPrescription.Enabled = !chkNo.Checked;
            errorProvider1.SetError(txtMedicationName, "");
            errorProvider1.SetError(txtDosage, "");
            errorProvider1.SetError(txtFrequency, "");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtVisitDescription_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _CheckNullOrEmpty((TextBox)sender);
        }

        private void txtDiagnosis_TextChanged(object sender, EventArgs e)
        {
            lblDiagnosisLength.Text = (txtDiagnosis.MaxLength - txtDiagnosis.Text.Length).ToString();
        }

        private void txtVisitDescription_TextChanged(object sender, EventArgs e)
        {
            lblVisitDescriptionLength.Text = (txtVisitDescription.MaxLength - txtVisitDescription.Text.Length).ToString();
        }

        private void txtSpecialInstructions_TextChanged(object sender, EventArgs e)
        {
            lblSpecialInstructionsLength.Text = (txtSpecialInstructions.MaxLength -  txtSpecialInstructions.Text.Length).ToString();
        }

        private void txtFrequency_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
 
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!_CheckBeforeSave())
            {
                MessageBox.Show("Enter a correct info.", "Not Correct", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            frmPay frm = new frmPay(_AppointmentID);

            frm.OnPayment += _SaveCompleteAppointmentInfo; // delegate payment info after paying. (Payment Method, Addtional Notes, Amount).

            frm.ShowDialog();
        }

        private void _SaveCompleteAppointmentInfo(object sender, string paymentMethod, string payAdditionalNotes, int amount) // delegate from Pay form.
        {
            // if there is a prescription.
            if (chkYes.Checked)
            {
                clsAppointments.stSetCompleteAppointmentWithPrescription completeAppointmentInfo = new clsAppointments.stSetCompleteAppointmentWithPrescription();
                
                // Medical Record info.
                completeAppointmentInfo.AppointmentID = _AppointmentID;
                completeAppointmentInfo.VisitDescription = txtVisitDescription.Text;
                completeAppointmentInfo.Diagnosis = txtDiagnosis.Text;
                completeAppointmentInfo.AdditionalNotes = txtAdditionalNotes.Text;
                // payment info.
                completeAppointmentInfo.PaymentDate = DateTime.Now;
                completeAppointmentInfo.PaymentMethod = paymentMethod;
                completeAppointmentInfo.AmountPaid = amount;
                completeAppointmentInfo.PayAdditionalNotes = payAdditionalNotes;
                // Prescription info.
                completeAppointmentInfo.MedicationName = txtMedicationName.Text;
                completeAppointmentInfo.Dosage = txtDosage.Text;
                completeAppointmentInfo.Frequency = txtFrequency.Text;
                completeAppointmentInfo.StartDate = dtpEndDate.Value;
                completeAppointmentInfo.EndDate = dtpStartDate.Value;
                completeAppointmentInfo.SpecialInstructions = txtSpecialInstructions.Text;


                if (clsAppointments.SetCompleteAppointmentWithPrescription(completeAppointmentInfo))
                {
                    MessageBox.Show("The Appointment was completed successfully.", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("An Error occurred while completing the appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                // if there is no prescription.
                clsAppointments.stSetCompleteAppointment completeAppointmentInfo = new clsAppointments.stSetCompleteAppointment();

                // Medical Record info.
                completeAppointmentInfo.AppointmentID = _AppointmentID;
                completeAppointmentInfo.VisitDescription = txtVisitDescription.Text;
                completeAppointmentInfo.Diagnosis = txtDiagnosis.Text;
                completeAppointmentInfo.AdditionalNotes = txtAdditionalNotes.Text;
                // payment info.
                completeAppointmentInfo.PaymentDate = DateTime.Now;
                completeAppointmentInfo.PaymentMethod = paymentMethod;
                completeAppointmentInfo.AmountPaid = amount;
                completeAppointmentInfo.PayAdditionalNotes = payAdditionalNotes;

                if (clsAppointments.SetCompleteAppointment(completeAppointmentInfo))
                {
                    MessageBox.Show("The Appointment was completed successfully.", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("An Error occurred while completing the appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            gbMedicalRecordInfo.Enabled = false;
            gbNeedPrescription.Enabled = false;
            gbPrescription.Enabled = false;
            btnSave.Enabled = false;
        }

        private void frmCompleteAppointment_Load(object sender, EventArgs e)
        {
            _FillInfo();
        }
    }
}
