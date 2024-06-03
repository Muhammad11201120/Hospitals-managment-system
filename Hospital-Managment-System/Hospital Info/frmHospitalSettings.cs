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

        int? _HospitalID = null;

        public frmAddUpdateHospital()
        {
            InitializeComponent();
        }

       
        void _Load()
        {

            if (clsGlobal.CurrentHospital == null)
            {
                MessageBox.Show("No Hospital with ID = " +
                    _HospitalID, "Hospital Information Not Complete",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }


            txtName.Text   = clsGlobal.CurrentHospital.HospitalName;
            txPhone.Text   = clsGlobal.CurrentHospital.HospitalPhone;
            txAddress.Text = clsGlobal.CurrentHospital.HospitalAddress;

            if (clsGlobal.CurrentHospital.HospitalLogo != null)
                pbHospitalImage.Load(clsGlobal.CurrentHospital.HospitalLogo);
            else
                pbHospitalImage.ImageLocation = null;
        }

        void _ResetDefaultValues()
        {
           
            if (clsGlobal.CurrentHospital == null)
            {
                lblTitle.Text = "Add Hospital Information";
            }
            else
            {
                lblTitle.Text = "Update Hospital Information";
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

            if (clsGlobal.CurrentHospital != null)
                _Load();
            else
                clsGlobal.CurrentHospital = new clsHospitalInfo();

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

            clsGlobal.CurrentHospital.HospitalName = txtName.Text;
            clsGlobal.CurrentHospital.HospitalAddress = txAddress.Text;
            clsGlobal.CurrentHospital.HospitalPhone  = txPhone.Text;

            if (pbHospitalImage != null)
                clsGlobal.CurrentHospital.HospitalLogo = pbHospitalImage.ImageLocation;
            else
                clsGlobal.CurrentHospital.HospitalLogo = null; 


            if (clsGlobal.CurrentHospital.Save())
            {
                _HospitalID = clsGlobal.CurrentHospital.ID;

                clsGlobal.RememberHospitalID(_HospitalID.ToString());

                lblTitle.Text = "Update Hospital Informartion";
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
