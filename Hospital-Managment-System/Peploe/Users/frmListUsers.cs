using HMS_BusinessLayer;
using Hospital_Managment_System.Empolyee.EmployeeControls;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hospital_Managment_System.Empolyee.Users
{
    public partial class frmListUsers : Form
    {
        public frmListUsers()
        {
            InitializeComponent();
        }

        private static DataTable dtListUsers = new DataTable();
        private DataView dvUsers = new DataView(dtListUsers);

        private void _Referesh()
        {
            dtListUsers = clsUser.GetAllUsers();
            dvUsers = dtListUsers.DefaultView;
            cbFilter.SelectedIndex = 0;
            txtFilter.Clear();
            _FillListUsers();
        }

        private void _FillListUsers()
        {
            dvUsers.RowFilter = "1 = 1";

            dgvListUsers.DataSource = dtListUsers;

            if (dgvListUsers.Rows.Count > 0)
            {
                dgvListUsers.Columns[0].HeaderText = "UserID";
                dgvListUsers.Columns[0].Width = 40;

                dgvListUsers.Columns[1].HeaderText = "NationalNo";
                dgvListUsers.Columns[1].Width = 70;

                dgvListUsers.Columns[2].HeaderText = "FullName";
                dgvListUsers.Columns[2].Width = 130;

                dgvListUsers.Columns[3].HeaderText = "Gender";
                dgvListUsers.Columns[3].Width = 50;

                dgvListUsers.Columns[4].HeaderText = "UserName";
                dgvListUsers.Columns[4].Width = 80;

                dgvListUsers.Columns[5].HeaderText = "IsActive";
                dgvListUsers.Columns[5].Width = 80;


                lblRecordCount.Text = dvUsers.Count.ToString();
            }
            else
                lblRecordCount.Text = "0";
        }

        private void _Search()
        {
            if (cbFilter.Text == "Gender")
            {
                dvUsers.RowFilter = string.Format("[Gender] LIKE '{0}%'", cbGender.Text);
                dgvListUsers.DataSource = dvUsers;
            }
            else if (cbFilter.Text == "IsActive")
            {
                if (cbIsActive.Text == "Yes")
                {
                    dvUsers.RowFilter = string.Format("[IsActive] = 1");
                    dgvListUsers.DataSource = dvUsers;
                }
                else
                {
                    dvUsers.RowFilter = string.Format("[IsActive] = 0");
                    dgvListUsers.DataSource = dvUsers;
                }
            }
            else
            {
                if (cbFilter.Text == "UserID")
                {
                    dvUsers.RowFilter = string.Format("[UserID] = {0}", txtFilter.Text);
                    dgvListUsers.DataSource = dvUsers;
                }
                else
                {
                    dvUsers.RowFilter = string.Format("[{0}] LIKE '{1}%'", cbFilter.Text, txtFilter.Text);
                    dgvListUsers.DataSource = dvUsers;
                }
            }

            lblRecordCount.Text = dgvListUsers.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmFindEmployee frm = new frmFindEmployee();

            frm.OnEmployeeSelected += _OpenAddUser;

            frm.ShowDialog();
        }

        private void _OpenAddUser(object sender, int? EmpID)
        {
            if (EmpID != null)
            {
                if (!clsUser.IsUserExistsByEmployeeID((int)EmpID))
                {
                    frmAddUpdateUser frm = new frmAddUpdateUser(EmpID);

                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("this employee is already User.", "Already User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmUserCardWithFilter frm = new frmUserCardWithFilter();

            frm.OnSelectUser += _OpenEditUser;

            frm.ShowDialog();
        }

        private void _OpenEditUser(object sender, int UserID)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser(UserID);

            frm.ShowDialog();
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text.Length > 0)
                _Search();
            else
                _FillListUsers();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "None")
            {
                txtFilter.Visible = false;
                cbGender.Visible = false;
                cbIsActive.Visible = false;
                _Referesh();
            }
            else if (cbFilter.Text == "Gender")
            {
                txtFilter.Visible = false;
                cbIsActive.Visible = false;
                cbGender.Visible = true;
                cbGender.SelectedIndex = 0;
            }
            else if (cbFilter.Text == "IsActive")
            {
                txtFilter.Visible = false;
                cbGender.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.SelectedIndex = 0;
            }
            else
            {
                cbIsActive.Visible = false;
                cbGender.Visible = false;
                txtFilter.Clear();
                txtFilter.Visible = true;

            }

        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIsActive.Text == "All")
                _FillListUsers();
            else
                _Search();

        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGender.Text == "All")
                _FillListUsers();
            else
                _Search();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "UserID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}