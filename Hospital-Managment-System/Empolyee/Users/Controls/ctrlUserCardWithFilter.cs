using HMS_BusinessLayer;
using System;
using System.Windows.Forms;

namespace Hospital_Managment_System.Empolyee.Users.Controls
{
    public partial class ctrlUserCardWithFilter : UserControl
    {
        public ctrlUserCardWithFilter()
        {
            InitializeComponent();
        }

        public int UserID { get; private set; }

        public clsUser UserInfo
        {
            get
            {
                return clsUser.Find(UserID);
            }
        }

        public void SelectFocus() => txtUserID.Focus();

        private void btnReset_Click(object sender, EventArgs e)
        {
            UserID = default;
            ctrlUserCard1.Reset();
            txtUserID.Clear();
            txtUserID.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (clsUser.IsUserExists(Convert.ToInt32(txtUserID.Text)))
            {
                ctrlUserCard1.LoadUserInfo(Convert.ToInt32(txtUserID.Text));
            }
            else
                MessageBox.Show("this User id is not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearch.PerformClick();
                return;
            }

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
