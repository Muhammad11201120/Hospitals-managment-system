using HMS_BusinessLayer;
using Hospital_Managment_System.Empolyee;
using Hospital_Managment_System.Empolyee.Doctor;
using Hospital_Managment_System.Empolyee.EmployeeControls;
using Hospital_Managment_System.Empolyee.Users;
using Hospital_Managment_System.Global;
using Hospital_Managment_System.Specialties;
using System;
using System.Windows.Forms;

namespace Hospital_Managment_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void addNewEmpolyeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateEmpolyee frmAddUpdateEmpolyee = new frmAddUpdateEmpolyee();

            frmAddUpdateEmpolyee.ShowDialog();

        }

        private void allEmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllEmployeesList frm = new frmAllEmployeesList();
            frm.ShowDialog();
        }

        private void addNewDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateDoctor frmAddUpdateDoctor = new frmAddUpdateDoctor();
            frmAddUpdateDoctor.ShowDialog();
        }

        private void findEmployeeUnderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFindEmployee findEmployee = new frmFindEmployee();

            findEmployee.ShowDialog();
        }

        private void empolyeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFindDoctorInfo doctorInfo = new frmFindDoctorInfo();

            doctorInfo.ShowDialog();
        }

        private void allDoctorsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this features is not implemented yet",
                "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void toolStripMenuAddNewUser_Click(object sender, EventArgs e)
        {
            frmFindEmployee frm = new frmFindEmployee();

            frm.OnEmployeeSelected += OpenAddUpdateUser;

            frm.ShowDialog();
        }

        private void OpenAddUpdateUser(object sender, int? EmpID)
        {
            if (EmpID != null)
            {
                if (!clsUser.IsUserExistsByEmployeeID((int)EmpID))
                {                
                    frmAddUpdateUser frm = new frmAddUpdateUser(EmpID);

                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("this Employee is already User.", "Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Not found Employee.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void toolStripMenuListUsers_Click(object sender, EventArgs e)
        {
            frmListUsers frm = new frmListUsers();

            frm.ShowDialog();
        }

        private void toolStripMenuFindUser_Click(object sender, EventArgs e)
        {
            frmUserCardWithFilter frm = new frmUserCardWithFilter();

            frm.ShowDialog();
        }

        private void findUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllSpecialtiesList frm = new frmAllSpecialtiesList();
            frm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAddUpdateEmpolyee AddupdateEmpolyee = new frmAddUpdateEmpolyee();

            AddupdateEmpolyee.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmAllEmployeesList EmployeeList = new frmAllEmployeesList();

            EmployeeList.ShowDialog();
        }

        private void allSpecialtiesListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAllSpecialtiesList allSpecialtiesList = new frmAllSpecialtiesList();

            allSpecialtiesList.ShowDialog();
        }

        private void hospitalSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateHospital Hospital = new frmAddUpdateHospital();

            Hospital.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
        }
    }

}