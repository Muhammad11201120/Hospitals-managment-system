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

namespace Hospital_Managment_System.Empolyee.Doctor
{
    public partial class frmDoctorsList : Form
    {
        DataTable dt = null;
        DataView dv = null;
        public frmDoctorsList()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            dt = clsDoctor.GetAllDoctors();
            dv = new DataView(dt);

            dataGridView1.DataSource = dv;

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns[0].HeaderText = "Doctor ID";
                dataGridView1.Columns[0].Width = 110;

                dataGridView1.Columns[1].HeaderText = "Full Name";
                dataGridView1.Columns[1].Width = 220;

                dataGridView1.Columns[2].HeaderText = "Speciality Name";
                dataGridView1.Columns[2].Width = 140;

                dataGridView1.Columns[3].HeaderText = "Price";
                dataGridView1.Columns[3].Width = 110;

            }
            lblRecordCount.Text = dataGridView1.Rows.Count.ToString();
        }


        private void frmDoctorsList_Load(object sender, EventArgs e)
        {
            cbxIlter.SelectedIndex = 0; 
            _LoadData();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdateDoctor AddUpdateDoctor = new frmAddUpdateDoctor();   

            AddUpdateDoctor.ShowDialog();
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
                lblRecordCount.Text = dataGridView1.Rows.Count.ToString();
                return;
            }

            if (FilterName == "DoctorID" || FilterName == "Price")
                //in this case we deal with integer not string.
                dv.RowFilter = string.Format("[{0}] = {1}", FilterName, txtFilter.Text.Trim());
            else
                dv.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterName, txtFilter.Text.Trim());

            lblRecordCount.Text = dataGridView1.Rows.Count.ToString();
        }

        private void showPersonalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("'Not Emplemented Yet..'");
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateDoctor AddUpdateDoctor = new frmAddUpdateDoctor();

            AddUpdateDoctor.ShowDialog();
            _LoadData();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateDoctor AddUpdateDoctor = new frmAddUpdateDoctor((int)dataGridView1.CurrentRow.Cells[0].Value);

            AddUpdateDoctor.ShowDialog();
            _LoadData();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Doctor [" +
                dataGridView1.CurrentRow.Cells[0].Value + "]",
                "Confirm Delete", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsDoctor.Delete((int)dataGridView1.CurrentRow.Cells[0].Value))
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
