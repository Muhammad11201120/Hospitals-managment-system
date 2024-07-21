using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Managment_System.Empolyee.EmployeeForms
{
    public partial class frmShowEmployeeDetails : Form
    {
        private int? _EmployeeID;
        public frmShowEmployeeDetails(int? EmbolyeeID)
        {
            InitializeComponent();
            _EmployeeID = EmbolyeeID;
        }
        private void _LoadEmployeeInfo()
        {
            if (_EmployeeID.HasValue)
            {
                ctrlEmployeeCard1.LoadEmployeeInfo(_EmployeeID);
            }
            else
            {
                MessageBox.Show("Data entry error", "Erroe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void frmShowEmployeeDetails_Load(object sender, EventArgs e)
        {
            _LoadEmployeeInfo();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
