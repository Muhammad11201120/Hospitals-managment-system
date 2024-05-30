using HMS_DataBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Managment_System.Specialties
{
    public partial class frmAddUpdateSpeciality : Form
    {
        enum _enMode
        {
            ADD = 0,
            UPDATE = 1
        }
        private _enMode _mode = _enMode.ADD;
        private int? _SpecialityId = null;
        private clsSpecialties _Specislity = null;

        public frmAddUpdateSpeciality()
        {
            InitializeComponent();
        }

        public frmAddUpdateSpeciality( int? specialityID )
        {
            InitializeComponent();
            _mode = _enMode.UPDATE;
            _SpecialityId = specialityID;
        }

        private void LoadData()
        {
            lblTitle.Text = "Update Speciality";
            _Specislity = clsSpecialties.Find( _SpecialityId );
            if ( _Specislity == null )
            {
                MessageBox.Show( "No Speciality with ID = " +
                    _SpecialityId, "Speciality Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                this.Close();
                return;
            }
            txtSpecialityName.Text = _Specislity.SpecialityName;
        }

        private void frmAddUpdateSpeciality_Load( object sender, EventArgs e )
        {
            if ( this._mode == _enMode.ADD )
            {
                _Specislity = new clsSpecialties();
                return;
            }
            LoadData();
        }
        private void txtSpecialityName_Validating( object sender, CancelEventArgs e )
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
        private void btnSave_Click( object sender, EventArgs e )
        {
            if ( !this.ValidateChildren() )
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show( "Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;

            }
            _Specislity.SpecialityName = txtSpecialityName.Text;
            if ( _Specislity.Save() )
            {
                MessageBox.Show( "Speciality Saved Successfully", "Speciality Saved", MessageBoxButtons.OK, MessageBoxIcon.Information );
                this.Close();
            }
            else
            {
                MessageBox.Show( "Speciality Not Saved", "Speciality Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }


    }
}
