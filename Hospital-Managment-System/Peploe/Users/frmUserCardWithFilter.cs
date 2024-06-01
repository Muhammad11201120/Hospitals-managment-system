using HMS_BusinessLayer;
using System;
using System.Windows.Forms;

namespace Hospital_Managment_System.Empolyee.Users
{
    public partial class frmUserCardWithFilter : Form
    {
        public frmUserCardWithFilter()
        {
            InitializeComponent();
        }

        public delegate void Action(object sender, int UserID);
        public event Action OnSelectUser;

        private void frmUserCardWithFilter_Load(object sender, EventArgs e)
        {
            ctrlUserCardWithFilter1.SelectFocus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (clsUser.IsUserExists(ctrlUserCardWithFilter1.UserID))
                if (OnSelectUser != null)
                    OnSelectUser?.Invoke(this, ctrlUserCardWithFilter1.UserID);

            this.Close();
        }
    }
}
