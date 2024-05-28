using HMS_DataBusinessLayer;
using Hospital_Managment_System.Global;
using HMS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Managment_System.Empolyee.Doctor
{
    public partial class frmAddUpdateDoctor : Form
    {
        public enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode;
        private int? _DoctorID;
        private clsDoctor _Doctor;
        public frmAddUpdateDoctor()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdateDoctor(int DoctorID)
        {
            InitializeComponent();
            _DoctorID = DoctorID;
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
        private void _ResetDefaultValues()
        {
            _Doctor = new clsDoctor();
            tbDoctorInfo.Enabled = false;
            lblTitle.Text = "Add New Doctor";
            txtPrice.Text = string.Empty;
            _FillSpecialtiesInComoboBox();

        }
        private void _LoadData()
        {
            _Doctor = clsDoctor.Find(_DoctorID);
            if (_Doctor == null)
            {
                MessageBox.Show("No Doctor with DoctorID = " + _DoctorID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            txtPrice.Text = _Doctor.Price.ToString();
            cbSpecialty.Text = clsSpecialties.Find(_Doctor.SpecialtyID.Value).SpecialityName;
            lblTitle.Text = "Update Doctor";
            ctrlEmployeeCardWithFilter1.LoadData(_Doctor.EmployeeID.Value);
        }
        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox Temp = (TextBox)sender;
            e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(Temp.Text + e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);
        }
        private void txtSalary_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPrice, "This field is required!");
            }
            else
                errorProvider1.SetError(txtPrice, null);
        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _Doctor.SpecialtyID = clsSpecialties.Find(cbSpecialty.Text).SpecialityID;
            _Doctor.Price = decimal.Parse(txtPrice.Text);
            _Doctor.EmployeeID = ctrlEmployeeCardWithFilter1.SelectedEmployeeInfo.EmployeeID;
            if (_Doctor.Save())
            {
                _DoctorID = _Doctor.DoctorID.Value;
                _Mode = enMode.Update;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmAddUpdateDoctor_Load(null, null);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void frmAddUpdateDoctor_Load(object sender, System.EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }
        private void tcDoctorInfo_Selecting(object sender, TabControlCancelEventArgs e)
        {
            btnDoctorInfoNext.PerformClick();
        }
        private void btnDoctorInfoNext_Click(object sender, System.EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tbDoctorInfo.Enabled = true;
                tcDoctorInfo.SelectedTab = tcDoctorInfo.TabPages["tbDoctorInfo"];
                return;
            }

            if (ctrlEmployeeCardWithFilter1.EmployeeID != null)
            {

                if (clsDoctor.isDoctorExistForEmployeeID(ctrlEmployeeCardWithFilter1.EmployeeID.Value))
                {

                    MessageBox.Show("Selected Employee already has a Doctor, choose another one.", "Select another Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlEmployeeCardWithFilter1.FilterFocus();
                }

                else
                {
                    btnSave.Enabled = true;
                    tbDoctorInfo.Enabled = true;
                    tcDoctorInfo.SelectedTab = tcDoctorInfo.TabPages["tbDoctorInfo"];
                }
            }

            else

            {
                MessageBox.Show("Please Select a Employee", "Select a Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlEmployeeCardWithFilter1.FilterFocus();

            }
        }
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void cbSpecialty_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbSpecialty.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(cbSpecialty, "This field is required!");
            }
            else
                errorProvider1.SetError(cbSpecialty, null);

        }
    }
}
