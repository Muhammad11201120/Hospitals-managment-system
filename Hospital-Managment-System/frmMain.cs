using Hospital_Managment_System.Empolyee;
using Hospital_Managment_System.Empolyee.Doctor;
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

        private void addNewDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateDoctor frmAddUpdateDoctor = new frmAddUpdateDoctor();
            frmAddUpdateDoctor.ShowDialog();
        }
    }
}
