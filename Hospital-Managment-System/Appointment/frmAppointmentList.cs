using HMS_DataBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Managment_System.Appointment
{
    public partial class frmAppointmentList : Form
    {
        private DataTable _dtAppointments;
        public frmAppointmentList()
        {
            InitializeComponent();
        }
        private void _dgvColumnDesign()
        {
            if (dgvAppointment.Columns.Count > 0)
            {
                dgvAppointment.Columns[0].HeaderText = "Appointment ID";
                dgvAppointment.Columns[0].Width = 150;

                dgvAppointment.Columns[1].HeaderText = "Patient ID";
                dgvAppointment.Columns[1].Width = 100;

                dgvAppointment.Columns[2].HeaderText = "Patient Full Name";
                dgvAppointment.Columns[2].Width = 150;

                dgvAppointment.Columns[3].HeaderText = "National No";
                dgvAppointment.Columns[3].Width = 170;

                dgvAppointment.Columns[4].HeaderText = "Patient Phone Number";
                dgvAppointment.Columns[4].Width = 150;

                dgvAppointment.Columns[5].HeaderText = "Gender";
                dgvAppointment.Columns[5].Width = 150;

                dgvAppointment.Columns[6].HeaderText = "Country Name";
                dgvAppointment.Columns[6].Width = 150;

                dgvAppointment.Columns[7].HeaderText = "Appointment Date Time";
                dgvAppointment.Columns[7].Width = 150;

                dgvAppointment.Columns[8].HeaderText = "Doctor ID";
                dgvAppointment.Columns[8].Width = 200;

                dgvAppointment.Columns[9].HeaderText = "Doctor Name";
                dgvAppointment.Columns[9].Width = 200;

                dgvAppointment.Columns[10].HeaderText = "Total Price";
                dgvAppointment.Columns[10].Width = 150;

                dgvAppointment.Columns[11].HeaderText = "Status";
                dgvAppointment.Columns[11].Width = 150;
                lblRecordCount.Text = dgvAppointment.Rows.Count.ToString();
            }
        }
        private void _LoadData()
        {
            
            dgvAppointment.DataSource= _dtAppointments=clsAppointments.GetAllAppointments();
            _dgvColumnDesign();
        }
        private void completeAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompleteAppointment frmCompleteAppointment = new frmCompleteAppointment((int)dgvAppointment.CurrentRow.Cells[0].Value);
            frmCompleteAppointment.ShowDialog();
            _LoadData();
        }
        private void frmAppointmentList_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        private void _FilterAppointments()
        {
            string query = "";
            if (txtFilterValue.Text !="")
            {
                switch (cmbFilter.Text)
                {
                    case "Appointment ID":
                        if (query != "")
                            query += " And (AppointmentID = " + txtFilterValue.Text + ") ";
                        else
                            query += " AppointmentID = " + txtFilterValue.Text + " ";
                        break;

                    case "Patient ID":
                        if (query != "")
                            query += " And (PatientID = " + txtFilterValue.Text + ") ";
                        else
                            query += " PatientID = " + txtFilterValue.Text + " ";
                        break;

                    case "Doctor ID":
                        if (query != "")
                            query += " And (DoctorID = " + txtFilterValue.Text + ") ";
                        else
                            query += " DoctorID = " + txtFilterValue.Text + " ";
                        break;

                    case "National No":
                        if (query != "")
                            query += " And (NationalNolike '" + txtFilterValue.Text + "%' )";
                        else
                            query += " NationalNo like '" + txtFilterValue.Text + "%' ";
                        break;
                    case "Patient Full Name":
                        if (query != "")
                            query += " And (FullName like '" + txtFilterValue.Text + "%' )";
                        else
                            query += "  FullName like '" + txtFilterValue.Text + "%' ";
                        break;
                    case "Doctor Name":
                        if (query != "")
                            query += " And (DoctorName like '" + txtFilterValue.Text + "%' )";
                        else
                            query += "  DoctorName like '" + txtFilterValue.Text + "%' ";
                        break;

                    case "Patient Phone Number":
                        if (query != "")
                            query += " And (PatientPhoneNumber like '" + txtFilterValue.Text + "%' )";
                        else
                            query += "  PatientPhoneNumber like '" + txtFilterValue.Text + "%' ";

                        break;

                    default:

                        break;
                }
            }


            if (query != "")
            {
                if (_dtAppointments.Rows.Count < 1)
                    return;
                _dtAppointments.DefaultView.RowFilter = query;

            }
            else
                _dtAppointments.DefaultView.RowFilter = "";
            lblRecordCount.Text = dgvAppointment.Rows.Count.ToString();

        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewAppontment app = new frmAddNewAppontment((int)dgvAppointment.CurrentRow.Cells[0].Value);
            app.ShowDialog();
            _LoadData();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsAppointments.Delete((int)dgvAppointment.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LoadData();
            }
            else
                MessageBox.Show("The deletion was not successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.Text == "Doctor ID"|| cmbFilter.Text == "Appointment ID" || cmbFilter.Text == "Patient ID" || cmbFilter.Text == "National No" || cmbFilter.Text == "Patient Phone Number")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterAppointments();
        }
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.Text != "None")
            {
                txtFilterValue.Visible = true;
                txtFilterValue.Focus();
            }
            else
            {
                txtFilterValue.Visible=false;
                txtFilterValue.Text = "";
            }
        }
    }
}