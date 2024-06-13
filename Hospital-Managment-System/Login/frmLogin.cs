using HMS_Business;
using HMS_BusinessLayer;
using Hospital_Managment_System.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Managment_System.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text != null && txtPassword.Text != null)

            {
                clsUser User = clsUser.Login(txtUserName.Text, txtPassword.Text);
                clsGlobal.CurrnetUser = User;
                if (User == null)
                {
                    string SourceName = "Hospital Managment System";
                    MessageBox.Show("Wrong UserName OR Password Contact Your Admin", "Wrong Log", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (!EventLog.SourceExists(SourceName))
                    {

                        EventLog.CreateEventSource(SourceName, "Application");
                        EventLog.WriteEntry(SourceName, "The Error is in Login Screen When You Click Login and Couldent found the User so it return null ", EventLogEntryType.Error);
                    }
                    return;





                }
            if (chkRememberMe.Checked == true)
            {
               EncryptionHelper.SaveEncryptedPasswordIfNotExists(txtUserName.Text, txtPassword.Text);
            }

                if (!User.IsActive)
                {
                    string SourceName = "Hospital Managment System";

                    if (!EventLog.SourceExists(SourceName))
                    {
                        EventLog.CreateEventSource(SourceName, "Application");

                    }
                    MessageBox.Show("This Account Is UnActive to solve that Contact Your Admin  ", "UnActive Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EventLog.WriteEntry(SourceName, "The Error is in Login Screen When UnActive User Account Try To Enter The System  ", EventLogEntryType.Error);
                    return;

                }
                frmMain frm = new frmMain();
                frm.ShowDialog();
            }
        }
        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void btnCloseTop_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string username;string password;
            bool IsUserExist= EncryptionHelper.GetUsernameAndPassword(out username, out password);

            if (IsUserExist)
            {
                txtUserName.Text= username;
                txtPassword.Text= password;
                txtPassword.PasswordChar = '*';
                
            }
            else
            {
                txtUserName.Text = "";
                txtPassword.Text = "";
            }
        }

        private void chkShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowHide.Checked)
            {
               
                txtPassword.PasswordChar = '\0';
                chkShowHide.Text = "Hide";
            }
            else
            {
                
                txtPassword.PasswordChar = '*';
                chkShowHide.Text = "Show";
            }
        }

        private void btnCloseTop_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
