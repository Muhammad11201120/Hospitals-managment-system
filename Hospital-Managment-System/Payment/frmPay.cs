using HMS_DataBusinessLayer;
using System;
using System.Windows.Forms;

namespace Hospital_Managment_System.Payment
{
    public partial class frmPay : Form
    {
        public frmPay(int appointmentID)
        {
            InitializeComponent();

            _AppointmentID = appointmentID;
        }

        private int _AppointmentID { get; set; }

        public delegate void OnPaymentComplete(object sender, string PaymentMethod, string AdditionalNotes, int Amount);
        public event OnPaymentComplete OnPayment;

        private bool _CheckBeforePaying()
        {
            if (cbPaymentMethod.SelectedIndex < 0) return false;

            return true;
        }

        private void frmPay_Load(object sender, EventArgs e)
        {
            lblAppointmentID.Text = _AppointmentID.ToString();
            dtpPaymentDate.Value = DateTime.Now;
            lblAmount.Text = clsAppointments.FindByAppointmentID(_AppointmentID).TotalPrice.ToString();
            cbPaymentMethod.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (!_CheckBeforePaying())
            {
                MessageBox.Show("Enter a correct info.", "Not Correct", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (OnPayment != null)
            {
                OnPayment?.Invoke(this, cbPaymentMethod.Text, txtAdditionalNotes.Text, Convert.ToInt32(lblAmount.Text));
            }

            this.Close();
        }
    }
}
