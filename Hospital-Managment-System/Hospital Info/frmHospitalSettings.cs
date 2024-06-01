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
using static Hospital_Managment_System.Empolyee.frmAddUpdateEmpolyee;

namespace Hospital_Managment_System
{
    public partial class frmAddUpdateHospital : Form
    {
        clsHospitalInfo _HospitalInfo;

        int? _HospitalID = null;

        enum enMOde { ADD , UPDATE};

        enMOde _Mode = enMOde.ADD;
        public frmAddUpdateHospital()
        {
            InitializeComponent();
            _Mode = enMOde.ADD;
        }

        public frmAddUpdateHospital(int HospitalID)
        {
            InitializeComponent();
            _HospitalID = HospitalID;

            _Mode = enMOde.UPDATE;
        }

        void _Load()
        {

            _HospitalInfo = clsHospitalInfo.FindByID(_HospitalID);

            if (_HospitalInfo == null)
            {
                MessageBox.Show("No Hospital with ID = " +
                    _HospitalID, "Person Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }


            txtName.Text   = _HospitalInfo.HospitalName;
            txPhone.Text   = _HospitalInfo.HospitalPhone;
            txAddress.Text = _HospitalInfo.HospitalAddress;

            if (_HospitalInfo.HospitalLogo != null)
                pbHospitalImage.Load(_HospitalInfo.HospitalLogo);
            else
                pbHospitalImage.ImageLocation = null;
        }

        void _ResetDefaultValues()
        {
           
            if (_Mode == enMOde.ADD)
            {
                lblTitle.Text = "Add Hopital Informatiom";
                _HospitalInfo = new clsHospitalInfo();
            }
            else
            {
                lblTitle.Text = "Update Hopital Informatiom";
            }

            txtName.Text = string.Empty;
            txPhone.Text   = string.Empty;
            txAddress.Text = string.Empty ;

                pbHospitalImage.ImageLocation = null;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbHospitalImage.Load(selectedFilePath);
            }
        }
       
        private void frmHospitalSettings_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMOde.UPDATE)
                _Load();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ( !this.ValidateChildren())
            {
                MessageBox.Show("Error: Data" +
                    " Is not Saved Successfully.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((pbHospitalImage.ImageLocation == null))
            {
                MessageBox.Show("Error: Please Upload photo",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _HospitalInfo.HospitalName = txtName.Text;
            _HospitalInfo.HospitalAddress = txAddress.Text;
            _HospitalInfo.HospitalPhone  = txPhone.Text;

            if (pbHospitalImage != null)
                _HospitalInfo.HospitalLogo = pbHospitalImage.ImageLocation;
            else
                _HospitalInfo.HospitalLogo = null; 


            if (_HospitalInfo.Save())
            {
                clsGlobal.CurrentHospital = _HospitalInfo;
                _Mode = enMOde.UPDATE;
                lblTitle.Text = "Update Hopital Informatiom";
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateHospital frmHospitalSettings = new frmAddUpdateHospital();

            frmHospitalSettings.ShowDialog();
        }
    }
}
