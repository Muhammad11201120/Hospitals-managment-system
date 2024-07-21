using HMS_BusinessLayer;
using System;
using System.Windows.Forms;

namespace Hospital_Managment_System.Empolyee.Users
{
    public partial class frmAddUpdateUser : Form
    {
        private enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode;

        private int? _EmpID;
        private int? _UserID;

        int? _OnEmployeeFound;
        private clsUser _UserInfo { get; set; }

        public frmAddUpdateUser()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
           
        }
        /*public frmAddUpdateUser(int? EmpID)
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
            _EmpID = EmpID;
        }*/
        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _UserID = UserID;
        }

        private void _FillUserInfo()
        {
            if (_Mode == enMode.Update)
            {
                lblUserID.Text = _UserID.ToString();

                _UserInfo = clsUser.Find((int)_UserID);
                lblEmpID.Text = _UserInfo.EmployeeID.ToString();
                txtUsername.Text = _UserInfo.UserName;
                txtPassword.Text = _UserInfo.Password;
                txtConfirmPassword.Text = _UserInfo.Password;
                chkIsActive.Checked = _UserInfo.IsActive;
                ctrlEmployeeCardWithFilter1.LoadData(_UserInfo.EmployeeID);

                lblTitle.Text = "Edit User With ID " + _UserID.ToString();
                Text = "Edit User With ID " + _UserID.ToString();

                lblShowUserCard.Enabled = true;
            }
            else
            {
                lblEmpID.Text = _EmpID.ToString();
                Text = "Add New User";
                lblShowUserCard.Enabled = false;
            }
        }

        private bool _CheckBeforeSave()
        {
            if (string.IsNullOrEmpty(txtUsername.Text)) return false;

            if (string.IsNullOrEmpty(txtPassword.Text)) return false;

            if (string.IsNullOrEmpty(txtConfirmPassword.Text)) return false;

            if (txtPassword.TextLength < 8) return false;

            if (txtConfirmPassword.Text != txtPassword.Text) return false;

            if (_Mode == enMode.Update)
            {
                if (txtUsername.Text != _UserInfo.UserName)
                {
                    if (clsUser.IsUsernameExists(txtUsername.Text))
                    {
                        errorProvider1.SetError(txtUsername, "this username already exists, choose another.");
                        return false;
                    }
                }
            }
            else
            {
                if (clsUser.IsUsernameExists(txtUsername.Text))
                {
                    errorProvider1.SetError(txtUsername, "this username already exists, choose another.");
                    return false;
                }
            }

            return true;
        }

        private bool _Save()
        {
            if (_Mode == enMode.AddNew)
                _UserInfo = new clsUser();

            _UserInfo.EmployeeID = Convert.ToInt32(lblEmpID.Text);
            _UserInfo.UserName = txtUsername.Text;
            _UserInfo.Password = txtPassword.Text;
            _UserInfo.IsActive = chkIsActive.Checked;

            return _UserInfo.Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _FillUserInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_CheckBeforeSave())
            {
                MessageBox.Show("Enter correct info.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            if (_Save())
            {
                lblUserID.Text = _UserInfo.UserID.ToString();

                if (_Mode == enMode.AddNew)
                    MessageBox.Show("Added User successfully.", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Updated User successfully.", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _UserID = _UserInfo.UserID;
                _Mode = enMode.Update;
                lblShowUserCard.Enabled = true;
                this.Close();
            }
            else
                MessageBox.Show("Add User is Filed.", "Filed", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "this is required.");
            }
            else if (txtPassword.TextLength < 8)
            {
                errorProvider1.SetError(txtPassword, "Enter at least 8 letters Or numbers.");
            }
            else
                errorProvider1.SetError(txtPassword, "");

        }

        private void txtConfirmPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                errorProvider1.SetError(txtConfirmPassword, "this is required.");
            }
            else if (txtConfirmPassword.Text != txtPassword.Text)
            {
                errorProvider1.SetError(txtConfirmPassword, "Verify the password.");
            }
            else
                errorProvider1.SetError(txtConfirmPassword, "");
        }

        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "this is required.");
            }
            else
                errorProvider1.SetError(txtUsername, "");


        }

        private void lblShowUserCard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUserInfoCard frm = new frmUserInfoCard((int)_UserID);

            frm.ShowDialog();
        }

        private void ctrlEmployeeCardWithFilter1_OnEmployeeSelected(int obj)
        {
            _OnEmployeeFound = obj;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_OnEmployeeFound == null)
            {
                MessageBox.Show("You Should Select Employee First !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MainTab.SelectedTab = MainTab.TabPages["tabPage2"];
            lblEmpID.Text=Convert.ToString( _OnEmployeeFound);
            btnSave.Enabled = true;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
