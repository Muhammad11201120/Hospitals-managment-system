using System;
using System.Windows.Forms;

namespace Hospital_Managment_System.Empolyee.EmployeeControls
{
    public partial class frmFindEmployee : Form
    {
        public frmFindEmployee()
        {
            InitializeComponent();
        }

        public delegate void EmpIDSelected(object sender, int? EmpID);
        public event EmpIDSelected OnEmployeeSelected;

        private void frmFindEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (OnEmployeeSelected != null)
                OnEmployeeSelected?.Invoke(this, ctrlEmployeeCardWithFilter1.EmployeeID);
        }

        private void frmFindEmployee_Load(object sender, EventArgs e)
        {
            ctrlEmployeeCardWithFilter1.FilterFocus();
        }
    }
}
