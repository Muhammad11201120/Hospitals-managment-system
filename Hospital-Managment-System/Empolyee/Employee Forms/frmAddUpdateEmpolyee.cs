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

namespace Hospital_Managment_System.Empolyee
{
    public partial class frmAddUpdateEmpolyee : Form
    {
        public delegate void HandledEventHandler( object sender, int EmployeeID );

        public event HandledEventHandler DataBack;
        enum enMode { AddNew = 0, Update = 1 };
        public enum enGendor { Male = 0, Female = 1 };

        enMode _Mode = enMode.AddNew;
        clsEmployee _Empolyee;
        int? _EmployeeID = null;
        public frmAddUpdateEmpolyee()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }
        public frmAddUpdateEmpolyee( int? EmployeeID )
        {
            InitializeComponent();

            _EmployeeID = EmployeeID;

            _Mode = enMode.Update;
        }
        void _FillComboBoxWithCountry()
        {
            DataTable dt = clsCountries.GetAllCountries();

            foreach ( DataRow row in dt.Rows )
            {
                cbCountry.Items.Add( row[ "CountryName" ] );
            }


        }
        void _ResetDefaultValues()
        {
            _FillComboBoxWithCountry();

            if ( _Mode == enMode.AddNew )
            {
                lblTitle.Text = "Add New Employee";
                _Empolyee = new clsEmployee();
            }
            else
            {
                lblTitle.Text = "Update Employee";
            }

            txtFirstName.Text  = string.Empty;
            txtLastName.Text   = string.Empty;
            txtNationalNo.Text = string.Empty;
            txtPhone.Text      = string.Empty;
            txtEmail.Text      = string.Empty;
            txtAddress.Text    = string.Empty;
            txtSalary.Text     = string.Empty;

            cbCountry.SelectedIndex = cbCountry.FindString( "Saudi Arabia" );

            rbMale.Checked = true;
            rbFemale.Checked = false;

            dtpDateOfBirth.Value = DateTime.Now;

            pbPersonImage.Image = Resources.Male_512;
            llRemoveImage.Enabled = false;
            llSetImage.Enabled = false;
        }
        void _LoadData()
        {
            _Empolyee = clsEmployee.Find( _EmployeeID );

            if ( _Empolyee == null )
            {
                MessageBox.Show( "No Empolyee with ID = " +
                    _EmployeeID, "Person Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                this.Close();
                return;
            }

            lblEmpolyeeID.Text = _Empolyee.EmployeeID.ToString();
            txtFirstName.Text = _Empolyee.FirstName;
            txtLastName.Text = _Empolyee.LastName;
            txtNationalNo.Text = _Empolyee.NationalNo;
            txtPhone.Text = _Empolyee.ContactInfo.PhoneNumber;
            txtEmail.Text = _Empolyee.ContactInfo.Email;
            txtAddress.Text = _Empolyee.Address;
            txtSalary.Text = _Empolyee.Salary.ToString();

            cbCountry.SelectedIndex = cbCountry.FindString( _Empolyee.CountryInfo.CountryName );

            dtpDateOfBirth.Value = _Empolyee.DateOfBirth;


            if ( _Empolyee.Gender == 0 )
            {
                rbMale.Checked = true;
                rbFemale.Checked = false;
                pbPersonImage.Image = Resources.Male_512;
            }
            else
            {
                rbMale.Checked = false;
                rbFemale.Checked = true;
                pbPersonImage.Image = Resources.Female_512;
            }
        }
        private void frmAddNewEmpolyee_Load( object sender, EventArgs e )
        {

            _ResetDefaultValues();

            if ( _Mode == enMode.Update )
                _LoadData();
        }

        bool _CreateConactInfo()
        {
            clsContact contact = new clsContact();

            contact.Email = txtEmail.Text;
            contact.PhoneNumber = txtPhone.Text;



            if ( contact.Save() )
            {
                _Empolyee.ContactID = contact.ContactID;
                return true;
            }
            else
                return false;



        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void rbMale_CheckedChanged( object sender, EventArgs e )
        {
            if ( pbPersonImage.ImageLocation == null )
                pbPersonImage.Image = Resources.Male_512;
        }

        private void rbFemale_CheckedChanged( object sender, EventArgs e )
        {
            if ( pbPersonImage.ImageLocation == null )
                pbPersonImage.Image = Resources.Female_512;
        }


        private void ValidateEmptyTextBox( object sender, CancelEventArgs e )
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ( ( TextBox ) sender );
            if ( string.IsNullOrEmpty( Temp.Text.Trim() ) )
            {
                e.Cancel = true;
                errorProvider1.SetError( Temp, "This field is required!" );
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError( Temp, null );
            }

        }

        private void txtNationalNo_Validating( object sender, CancelEventArgs e )
        {
            if ( string.IsNullOrEmpty( txtNationalNo.Text.Trim() ) )
            {
                e.Cancel = true;
                errorProvider1.SetError( txtNationalNo, "This field is required!" );
                return;
            }
            else
            {
                errorProvider1.SetError( txtNationalNo, null );
            }

            if ( txtNationalNo.Text.Trim() != _Empolyee.NationalNo &&
                clsEmployee.IsPersonExists( txtNationalNo.Text.Trim() ) )
            {
                e.Cancel = true;
                errorProvider1.SetError( txtNationalNo, "National Number is used for another person!" );

            }
            else
            {
                errorProvider1.SetError( txtNationalNo, null );
            }
        }

        private void txtEmail_Validating( object sender, CancelEventArgs e )
        {
            if ( txtEmail.Text.Trim() == string.Empty )
                return;

            if ( !clsValidatoin.ValidateEmail( txtEmail.Text ) )
            {
                e.Cancel = true;
                errorProvider1.SetError( txtEmail, "Invalid Email Address Format!" );
            }
            else
            {
                errorProvider1.SetError( txtEmail, null );
            };
        }

        private void btnSave_Click_1( object sender, EventArgs e )
        {
            if ( !_CreateConactInfo() || !this.ValidateChildren() )
            {
                MessageBox.Show( "Error: Data" +
                    " Is not Saved Successfully.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            int? CountryID = clsCountries.Find( cbCountry.Text ).CountryID;

            _Empolyee.FirstName = txtFirstName.Text;
            _Empolyee.LastName = txtLastName.Text;
            _Empolyee.NationalNo = txtNationalNo.Text;
            _Empolyee.DateOfBirth = dtpDateOfBirth.Value;
            _Empolyee.CountryID = CountryID;
            _Empolyee.Address = txtAddress.Text;
            _Empolyee.Salary = decimal.Parse( txtSalary.Text );

            if ( rbMale.Checked )
                _Empolyee.Gender = ( byte ) enGendor.Male;
            else
                _Empolyee.Gender = ( byte ) enGendor.Female;


            if ( _Empolyee.Save() )
            {
                lblEmpolyeeID.Text = _Empolyee.EmployeeID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update Person";

                MessageBox.Show( "Data Saved Successfully.",
                    "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information );
                DataBack?.Invoke( this, _Empolyee.EmployeeID.Value );
            }
            else
            {
                MessageBox.Show( "Error: Data" +
                 " Is not Saved Successfully.",
                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}
