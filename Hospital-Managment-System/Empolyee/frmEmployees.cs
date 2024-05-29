using Hospital_Managment_System.Empolyee.Doctor;
using System;
using System.Windows.Forms;

namespace Hospital_Managment_System.Empolyee
{
    public partial class frmEmployees : Form
    {
        private Hospital_Managment_System.frmEmployees _frmMain;

        public frmEmployees(Hospital_Managment_System.frmEmployees main)
        {
            InitializeComponent();

            _frmMain = main;
        }

        struct stChildForms
        {
            // this forms for can be navigated without having to reload the page.
            public frmEmployees Employees { get; set; }
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            frmAddUpdateDoctor frm = new frmAddUpdateDoctor(this);

            _frmMain.OpenChildSubForm(frm);

            this.Hide();
        }
    }
}
