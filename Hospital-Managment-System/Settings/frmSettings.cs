using Hospital_Managment_System.Appointment;
using Hospital_Managment_System.Empolyee.Doctor;
using Hospital_Managment_System.Empolyee.Users;
using Hospital_Managment_System.Empolyee;
using System;
using System.Windows.Forms;

namespace Hospital_Managment_System.Settings
{
    public partial class frmSettings : Form
    {
        public frmMain frmMain;
        
        public frmSettings()
        {
            InitializeComponent();
        }
        struct stChildForms
        {
            public frmAddUpdateHospital frmAddUpdateHospital { get; set; }

        }
        private stChildForms Forms = new stChildForms();

        private Form activeForm;
        private Form activeSubForm;

        public void OpenChailedForm(Form ChildForm)
        {
            try
            {
                if (activeForm != null)
                {
                    activeForm.Close();

                    if (activeSubForm != null)
                        activeSubForm.Close();
                }

                //ChangeThameColor(ThameColor);
                activeForm = ChildForm;
                ChildForm.TopLevel = false;
                ChildForm.FormBorderStyle = FormBorderStyle.None;
                ChildForm.Dock = DockStyle.Fill;
                this.panelForms.Controls.Add(ChildForm);
                this.panelForms.Tag = ChildForm;
                ChildForm.BringToFront();
                ChildForm.Show();
                //lblTitle.Text = ChildForm.Text;
                //ImageTitle(imageTitle);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void OpenChildSubForm(Form ChildSubForm)
        {
            try
            {
                if (activeSubForm != null)
                {
                    //activeForm.Close();
                    activeSubForm.Hide();
                }

                //ChangeThameColor(ThameColor);
                activeSubForm = ChildSubForm;
                ChildSubForm.TopLevel = false;
                ChildSubForm.FormBorderStyle = FormBorderStyle.None;
                ChildSubForm.Dock = DockStyle.Fill;
                this.panelForms.Controls.Add(ChildSubForm);
                this.panelForms.Tag = ChildSubForm;
                ChildSubForm.BringToFront();
                ChildSubForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmSettings(frmMain main)
        {
            InitializeComponent();

            frmMain = main;
        }


        private void frmSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnHospitalInfo_Click(object sender, EventArgs e)
        {
            Forms.frmAddUpdateHospital = new frmAddUpdateHospital(this);

            OpenChildSubForm(Forms.frmAddUpdateHospital);
        }
    }
}
