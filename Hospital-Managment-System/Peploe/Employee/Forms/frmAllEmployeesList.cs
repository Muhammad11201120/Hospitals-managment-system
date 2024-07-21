using HMS_DataBusinessLayer;
using Hospital_Managment_System.Empolyee.EmployeeForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hospital_Managment_System.Empolyee
{
    public partial class frmAllEmployeesList : Form
    {
        public frmMain frmMain;

        DataTable dt = null;
        DataView dv = null;
        public frmAllEmployeesList(frmMain main)
        {
            InitializeComponent();

            this.frmMain = main;
        }

        private void _LoadData()
        {
            dt = clsEmployee.GetAllEmployees();
            dv = new DataView( dt );
            dgvEmployeesList.DataSource = dv;

            if ( dgvEmployeesList.Rows.Count > 0 )
            {
                dgvEmployeesList.Columns[ 0 ].HeaderText = "Employee ID";
                dgvEmployeesList.Columns[ 0 ].Width = 70;
                dgvEmployeesList.Columns[ 1 ].HeaderText = "National Number";
                dgvEmployeesList.Columns[ 1 ].Width = 90;
                dgvEmployeesList.Columns[ 2 ].HeaderText = "Full Name";
                dgvEmployeesList.Columns[ 2 ].Width = 130;
                dgvEmployeesList.Columns[ 3 ].HeaderText = "Date Of Birth";
                dgvEmployeesList.Columns[ 3 ].Width = 140;
                dgvEmployeesList.Columns[ 4 ].HeaderText = "Gender";
                dgvEmployeesList.Columns[ 4 ].Width = 60;
                dgvEmployeesList.Columns[ 5 ].HeaderText = "Phone Number";
                dgvEmployeesList.Columns[ 5 ].Width = 90;
                dgvEmployeesList.Columns[ 6 ].HeaderText = "Email";
                dgvEmployeesList.Columns[ 6 ].Width = 180;
                dgvEmployeesList.Columns[ 7 ].HeaderText = "Address";
                dgvEmployeesList.Columns[ 7 ].Width = 180;
                dgvEmployeesList.Columns[ 8 ].HeaderText = "Country Name";
                dgvEmployeesList.Columns[ 8 ].Width = 100;
                dgvEmployeesList.Columns[ 9 ].HeaderText = "Salary";
                dgvEmployeesList.Columns[ 9 ].Width = 110;
            }
            lblRecordCount.Text = dgvEmployeesList.Rows.Count.ToString();
        }

        private void frmAllEmployeesList_Load( object sender, EventArgs e )
        {
            cbxIlter.SelectedIndex = 0;

            _LoadData();
        }

        private void btnAddNew_Click( object sender, EventArgs e )
        {
            frmAddUpdateEmpolyee frm = new frmAddUpdateEmpolyee();

            frmMain.OpenChildSubForm(frm);

            _LoadData();
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void cbxIlter_SelectedIndexChanged( object sender, EventArgs e )
        {
            txtFilter.Visible = ( cbxIlter.SelectedIndex != 0 );
            if ( txtFilter.Visible )
            {
                txtFilter.Text = "";
                txtFilter.Focus();
            }
        }

        private void txtFilter_KeyPress( object sender, KeyPressEventArgs e )
        {
            if ( cbxIlter.Text == "EmployeeID" || cbxIlter.Text == "PhoneNumber" )
            {
                e.Handled = !char.IsDigit( e.KeyChar ) && !char.IsControl( e.KeyChar );
            }
        }

        private void txtFilter_TextChanged( object sender, EventArgs e )
        {
            string FilterName = string.Empty;
            switch ( cbxIlter.Text )
            {
                case "EmployeeID":
                    FilterName = "EmployeeID";
                    break;
                case "NationalNo":
                    FilterName = "NationalNo";
                    break;
                case "Name":
                    FilterName = "FullName";
                    break;
                case "DateOfBirth":
                    FilterName = "DateOfBirth";
                    break;
                case "Gender":
                    FilterName = "Gender";
                    break;
                case "PhoneNumber":
                    FilterName = "PhoneNumber";
                    break;
                case "Email":
                    FilterName = "Email";
                    break;
                case "Address":
                    FilterName = "Address";
                    break;
                case "Country":
                    FilterName = "CountryName";
                    break;
                case "Salary":
                    FilterName = "Salary";
                    break;
                default:
                    FilterName = "None";
                    break;
            }
            //Reset the filters in case nothing selected or filter value conains nothing.
            if ( txtFilter.Text.Trim() == "" || FilterName == "None" )
            {
                dv.RowFilter = "";
                lblRecordCount.Text = dgvEmployeesList.Rows.Count.ToString();
                return;
            }

            if ( FilterName == "EmployeeID" )
                //in this case we deal with integer not string.
                dv.RowFilter = string.Format( "[{0}] = {1}", FilterName, txtFilter.Text.Trim() );
            else
                dv.RowFilter = string.Format( "[{0}] LIKE '{1}%'", FilterName, txtFilter.Text.Trim() );

            lblRecordCount.Text = dgvEmployeesList.Rows.Count.ToString();
        }

        private void addNewEmployeeToolStripMenuItem_Click( object sender, EventArgs e )
        {
            btnAddNew.PerformClick();
        }

        private void updateToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmAddUpdateEmpolyee frm = new frmAddUpdateEmpolyee( ( int ) dgvEmployeesList.CurrentRow.Cells[ 0 ].Value );
            
            //frm.ShowDialog();
            frmMain.OpenChildSubForm( frm );
            _LoadData();
        }

        private void deleteToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if ( MessageBox.Show( "Are you sure you want to delete Employee [" + dgvEmployeesList.CurrentRow.Cells[ 0 ].Value + "]", "Confirm Delete",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK )

            {

                //Perform Delele and refresh
                if ( clsEmployee.DeleteEmployee( ( int ) dgvEmployeesList.CurrentRow.Cells[ 0 ].Value ) )
                {
                    MessageBox.Show( "Employee Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    _LoadData();
                }

                else
                    MessageBox.Show( "Employee was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );

            }
        }

        private void exitToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void showPersonalInfoToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmShowEmployeeDetails frmShowEmployeeDetails = new frmShowEmployeeDetails((int)dgvEmployeesList.CurrentRow.Cells[0].Value);

            frmMain.OpenChildSubForm(frmShowEmployeeDetails);
        }
    }
}
