using HMS_DataBusinessLayer;
using Hospital_Managment_System.Empolyee.EmployeeControls;
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
    public partial class ctrlPatientInfoWithFilter : UserControl
    {
        public event Action<int> OnPatientSelected;
        protected virtual void PatientSelected(int PatientID)
        {
            Action<int> handler = OnPatientSelected;
            if (handler != null)
            {
                handler(PatientID);
            }
        }
        private bool _ShowAddPatient = true;
        public bool ShowAddPatient
        {
            get
            {
                return _ShowAddPatient;
            }
            set
            {
                _ShowAddPatient = value;
                btnAddNewPatient.Visible = _ShowAddPatient;
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
        public int? PatientID
        {
            get { return ctrlPatient1.PatientID; }
        }
        public void LoadData(int PatientID)
        {
            ctrlPatient1.LoadPatientInfo(PatientID);
            txtFilterValue.Text = PatientID.ToString();
            cbFilterBy.SelectedIndex = 0;
        }
        public clsPatient SelectedPatientInfo
        {
            get { return ctrlPatient1.SelectedPatientInfo; }
        }
        public ctrlPatientInfoWithFilter()
        {
            InitializeComponent();
        }

        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }
            if (cbFilterBy.Text == "Employee ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void _FindNow()
        {
            if (txtFilterValue.Text == "")
                return;
            switch (cbFilterBy.Text)
            {
                case "Employee ID":
                    ctrlPatient1.LoadPatientInfo (int.Parse(txtFilterValue.Text));
                    break;
            }
            if (OnPatientSelected != null && FilterEnabled && SelectedPatientInfo != null)
                OnPatientSelected(ctrlPatient1.PatientID.Value);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            _FindNow();

        }
        private void DataBack(object sender, int PatientID)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Text = PatientID.ToString();
            ctrlPatient1.LoadPatientInfo(PatientID);
        }

        private void btnAddNewPatient_Click(object sender, EventArgs e)
        {
            frmAddPatient frmAddUpdatePatient = new frmAddPatient();
            frmAddUpdatePatient.DataBack += DataBack;
            frmAddUpdatePatient.ShowDialog();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "");

        }

        private void ctrlPatientInfoWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0; // select filter by EmployeeID.
            FilterFocus();
        }
    }
}
