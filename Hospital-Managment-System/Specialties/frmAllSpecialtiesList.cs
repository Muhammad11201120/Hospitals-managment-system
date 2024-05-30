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
    public partial class frmAllSpecialtiesList : Form
    {
        DataTable dt = null;
        DataView dv = null;
        public frmAllSpecialtiesList()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            dt = clsSpecialties.GetAllSpecialties();
            dv = new DataView( dt );
            dataGridView1.DataSource = dv;
            if ( dataGridView1.Rows.Count > 0 )
            {
                dataGridView1.Columns[ 0 ].HeaderText = "Speciatlity ID";
                dataGridView1.Columns[ 0 ].Width = 120;
                dataGridView1.Columns[ 1 ].HeaderText = "Speciatlity Name";
            }
            lblRecordCount.Text = dv.Count.ToString();
        }
        private void frmAllSpecialtiesList_Load( object sender, EventArgs e )
        {
            _LoadData();
        }

        private void btnAddNew_Click( object sender, EventArgs e )
        {
            frmAddUpdateSpeciality frm = new frmAddUpdateSpeciality();
            frm.ShowDialog();
            _LoadData();
        }

        private void addNewSpecialityToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmAddUpdateSpeciality frm = new frmAddUpdateSpeciality();
            frm.ShowDialog();
            _LoadData();
        }

        private void updateSpecialityToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmAddUpdateSpeciality frm = new frmAddUpdateSpeciality( ( int ) dataGridView1.CurrentRow.Cells[ 0 ].Value );
            frm.ShowDialog();
            _LoadData();
        }

        private void deleteSpecialityToolStripMenuItem_Click( object sender, EventArgs e )
        {
            int id = ( int ) dataGridView1.CurrentRow.Cells[ 0 ].Value;
            if ( MessageBox.Show( "Are you sure you want to delete this Speciality?", "Delete Speciality", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes )
            {
                if ( clsSpecialties.DeleteSpeciality( id ) )
                {
                    MessageBox.Show( "Speciality Deleted Successfully", "Speciality Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    _LoadData();
                }
                else
                {
                    MessageBox.Show( "Speciality Not Deleted", "Speciality Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                }
            }
        }

        private void closeToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }


    }
}
