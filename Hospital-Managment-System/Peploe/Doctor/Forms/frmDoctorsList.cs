using HMS_DataBusinessLayer;
using Hospital_Managment_System.Empolyee.Doctor.DoctorForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hospital_Managment_System.Empolyee.Doctor
{
    public partial class frmDoctorsList : Form
    {
        public frmMain frmMain;

        DataTable dt = null;
        DataView dv = null;
        public frmDoctorsList(frmMain main)
        {
            InitializeComponent();

            this.frmMain = main;
        }

        private void _LoadData()
        {
            dt = clsDoctor.GetAllDoctors();
            dv = new DataView(dt);

            dgvDoctorsList.DataSource = dv;

            if (dgvDoctorsList.Rows.Count > 0)
            {
                dgvDoctorsList.Columns[0].HeaderText = "Doctor ID";
                dgvDoctorsList.Columns[0].Width = 110;

                dgvDoctorsList.Columns[1].HeaderText = "Full Name";
                dgvDoctorsList.Columns[1].Width = 220;

                dgvDoctorsList.Columns[2].HeaderText = "Speciality Name";
                dgvDoctorsList.Columns[2].Width = 140;

                dgvDoctorsList.Columns[3].HeaderText = "Price";
                dgvDoctorsList.Columns[3].Width = 110;

            }
            lblRecordCount.Text = dgvDoctorsList.Rows.Count.ToString();
        }


        private void frmDoctorsList_Load(object sender, EventArgs e)
        {
            cbxIlter.SelectedIndex = 0; 
            _LoadData();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdateDoctor AddUpdateDoctor = new frmAddUpdateDoctor();   

            frmMain.OpenChildSubForm(AddUpdateDoctor);

            _LoadData();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxIlter.Text == "Doctor ID" || cbxIlter.Text == "Price")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void cbxIlter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = (cbxIlter.SelectedIndex != 0);
            if (txtFilter.Visible)
            {
                txtFilter.Text = "";
                txtFilter.Focus();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterName = string.Empty;
            switch (cbxIlter.Text)
            {
                case "Doctor ID":
                    FilterName = "DoctorID";
                    break;

                case "Name":
                    FilterName = "Full Name";
                    break;

                case "Speciality Name":
                    FilterName = "SpecialityName";
                    break;

                case "Price":
                    FilterName = "Price";
                    break;
               
            }
            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilter.Text.Trim() == "" || FilterName == "None")
            {
                dv.RowFilter = "";
                lblRecordCount.Text = dgvDoctorsList.Rows.Count.ToString();
                return;
            }

            if (FilterName == "DoctorID" || FilterName == "Price")
                //in this case we deal with integer not string.
                dv.RowFilter = string.Format("[{0}] = {1}", FilterName, txtFilter.Text.Trim());
            else
                dv.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterName, txtFilter.Text.Trim());

            lblRecordCount.Text = dgvDoctorsList.Rows.Count.ToString();
        }

        private void showPersonalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowDoctorDetails frm = new frmShowDoctorDetails((int)dgvDoctorsList.CurrentRow.Cells[0].Value);
            
            frmMain.OpenChildSubForm(frm);
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNew.PerformClick();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateDoctor AddUpdateDoctor = new frmAddUpdateDoctor((int)dgvDoctorsList.CurrentRow.Cells[0].Value);

            frmMain.OpenChildSubForm(AddUpdateDoctor);

            _LoadData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Doctor [" +
                dgvDoctorsList.CurrentRow.Cells[0].Value + "]",
                "Confirm Delete", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsDoctor.Delete((int)dgvDoctorsList.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Doctor Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadData();
                }

                else
                    MessageBox.Show("Doctor was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
