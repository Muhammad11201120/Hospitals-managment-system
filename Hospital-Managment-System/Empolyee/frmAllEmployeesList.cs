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

namespace Hospital_Managment_System.Empolyee
{
    public partial class frmAllEmployeesList : Form
    {
        DataTable dt = null;
        DataView dv = null;
        public frmAllEmployeesList()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            dt = clsEmployee.GetAllEmployees();
            dv = new DataView( dt );
            dataGridView1.DataSource = dv;
            cbxIlter.SelectedIndex = 0;

            if ( dataGridView1.Rows.Count > 0 )
            {
                dataGridView1.Columns[ 0 ].HeaderText = "Employee ID";
                dataGridView1.Columns[ 0 ].Width = 110;
                dataGridView1.Columns[ 1 ].HeaderText = "National Number";
                dataGridView1.Columns[ 1 ].Width = 120;
                dataGridView1.Columns[ 2 ].HeaderText = "Full Name";
                dataGridView1.Columns[ 2 ].Width = 180;
                dataGridView1.Columns[ 3 ].HeaderText = "Date Of Birth";
                dataGridView1.Columns[ 3 ].Width = 140;
                dataGridView1.Columns[ 4 ].HeaderText = "Gender";
                dataGridView1.Columns[ 4 ].Width = 110;
                dataGridView1.Columns[ 5 ].HeaderText = "Phone Number";
                dataGridView1.Columns[ 5 ].Width = 110;
                dataGridView1.Columns[ 6 ].HeaderText = "Email";
                dataGridView1.Columns[ 6 ].Width = 180;
                dataGridView1.Columns[ 7 ].HeaderText = "Address";
                dataGridView1.Columns[ 7 ].Width = 180;
                dataGridView1.Columns[ 8 ].HeaderText = "Country Name";
                dataGridView1.Columns[ 8 ].Width = 120;
                dataGridView1.Columns[ 9 ].HeaderText = "Salary";
                dataGridView1.Columns[ 9 ].Width = 110;
            }
            lblRecordCount.Text = dataGridView1.Rows.Count.ToString();
        }

        private void frmAllEmployeesList_Load( object sender, EventArgs e )
        {
            _LoadData();
        }

        private void btnAddNew_Click( object sender, EventArgs e )
        {
            frmAddUpdateEmpolyee frm = new frmAddUpdateEmpolyee();
            frm.ShowDialog();
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
                lblRecordCount.Text = dataGridView1.Rows.Count.ToString();
                return;
            }

            if ( FilterName == "EmployeeID" )
                //in this case we deal with integer not string.
                dv.RowFilter = string.Format( "[{0}] = {1}", FilterName, txtFilter.Text.Trim() );
            else
                dv.RowFilter = string.Format( "[{0}] LIKE '{1}%'", FilterName, txtFilter.Text.Trim() );

            lblRecordCount.Text = dataGridView1.Rows.Count.ToString();
        }
    }
}
