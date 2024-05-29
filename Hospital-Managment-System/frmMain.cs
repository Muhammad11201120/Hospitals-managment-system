using Hospital_Managment_System.Empolyee;
using Hospital_Managment_System.Empolyee.Doctor;
using Hospital_Managment_System.Empolyee.EmployeeControls;
using Hospital_Managment_System.Specialties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Managment_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void addNewEmpolyeeToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmAddUpdateEmpolyee frmAddUpdateEmpolyee = new frmAddUpdateEmpolyee();

            frmAddUpdateEmpolyee.ShowDialog();

        }

        private void allEmToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmAllEmployeesList frm = new frmAllEmployeesList();
            frm.ShowDialog();
        }

        private void addNewDoctorToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmAddUpdateDoctor frmAddUpdateDoctor = new frmAddUpdateDoctor();
            frmAddUpdateDoctor.ShowDialog();
        }

        private void findEmployeeUnderToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmFindEmployee findEmployee = new frmFindEmployee();

            findEmployee.ShowDialog();
        }

        private void empolyeesToolStripMenuItem_Click( object sender, EventArgs e )
        {

        }

        private void findDoctorToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmFindDoctorInfo doctorInfo = new frmFindDoctorInfo();

            doctorInfo.ShowDialog();
        }

        private void allDoctorsListToolStripMenuItem_Click( object sender, EventArgs e )
        {
            MessageBox.Show( "this features is not implemented yet",
                "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }

        private void toolStripMenuItem5_Click( object sender, EventArgs e )
        {
            MessageBox.Show( "this features is not implemented yet",
                "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }

        private void toolStripMenuItem6_Click( object sender, EventArgs e )
        {
            MessageBox.Show( "this features is not implemented yet",
                "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }

        private void toolStripMenuItem7_Click( object sender, EventArgs e )
        {
            MessageBox.Show( "this features is not implemented yet",
                "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }

        private void findUserToolStripMenuItem_Click( object sender, EventArgs e )
        {
            MessageBox.Show( "this features is not implemented yet",
                "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }

        private void toolStripMenuItem2_Click( object sender, EventArgs e )
        {
            frmAddUpdateEmpolyee AddupdateEmpolyee = new frmAddUpdateEmpolyee();

            AddupdateEmpolyee.ShowDialog();
        }

        private void toolStripMenuItem3_Click( object sender, EventArgs e )
        {
            frmAllEmployeesList EmployeeList = new frmAllEmployeesList();

            EmployeeList.ShowDialog();
        }

        private void allSpecialtiesListToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmAllSpecialtiesList frm = new frmAllSpecialtiesList();
            frm.ShowDialog();
        }
    }
}
