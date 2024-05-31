using System;
using System.Windows.Forms;

namespace Hospital_Managment_System.Empolyee.Users
{
    public partial class frmUserInfoCard : Form
    {
        public frmUserInfoCard(int userID)
        {
            InitializeComponent();

            _UserID = userID;
        }

        private int _UserID { get; set; }

        private void frmUserInfoCard_Load(object sender, EventArgs e)
        {
            // if user id is not found, will be close screen.
            if (!ctrlUserCard1.LoadUserInfo(_UserID))
            {
                
                MessageBox.Show("User is not found.", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
        }
    }
}
