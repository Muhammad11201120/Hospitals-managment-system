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
        }
        private void frmAllSpecialtiesList_Load( object sender, EventArgs e )
        {
            _LoadData();
        }

        private void btnAddNew_Click( object sender, EventArgs e )
        {
            frmAddUpdateSpeciality frm = new frmAddUpdateSpeciality();
            frm.ShowDialog();
        }
    }
}
