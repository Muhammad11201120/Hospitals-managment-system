using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS_BusinessLayer;
using HMS_DataBusinessLayer;

namespace Hospital_Managment_System.Empolyee.EmployeeControls
{
    public partial class ctrlEmployeeCardWithFilter : UserControl
    {
        public event Action<int> OnEmployeeSelected;
        protected virtual void EmployeeSelected(int EmployeeID)
        {
            Action<int> handler = OnEmployeeSelected;
            if (handler != null)
            {
                handler(EmployeeID);
            }
        }
        private bool _ShowAddEmployee = true;
        public bool ShowAddEmployee
        {
            get
            {
                return _ShowAddEmployee;
            }
            set
            {
                _ShowAddEmployee = value;
                btnAddNewEmployee.Visible = _ShowAddEmployee;
            }
        }
        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }
        public int? EmployeeID
        {
            get { return ctrlEmployeeCard1.EmployeeID; }
        }
        public void LoadData(int EmployeeID)
        {
            ctrlEmployeeCard1.LoadEmployeeInfo(EmployeeID);
            txtFilterValue.Text = EmployeeID.ToString();
            cbFilterBy.SelectedIndex = 0;
        }
        public clsEmployee SelectedEmployeeInfo
        {
            get { return ctrlEmployeeCard1.SelectedEmployeeInfo; }
        }
        public ctrlEmployeeCardWithFilter()
        {
            InitializeComponent();
        }
       public void FilterFocus()
        {
            txtFilterValue.Focus();
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }
            if (cbFilterBy.Text == "Employee ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void _FindNow()
        {
            if (txtFilterValue.Text == "")
                return;
            switch(cbFilterBy.Text)
            {
                case "Employee ID":
                    ctrlEmployeeCard1.LoadEmployeeInfo(int.Parse(txtFilterValue.Text));
                    break;
            }
            if (OnEmployeeSelected != null && FilterEnabled&&SelectedEmployeeInfo!=null)
                OnEmployeeSelected(ctrlEmployeeCard1.EmployeeID.Value);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            _FindNow();
        }
        private void DataBack(object sender ,int EmployeeID)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Text=EmployeeID.ToString();
            ctrlEmployeeCard1.LoadEmployeeInfo(EmployeeID);
        }
        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            frmAddUpdateEmpolyee frmAddUpdateEmpolyee = new frmAddUpdateEmpolyee();
            frmAddUpdateEmpolyee.DataBack += DataBack;
            frmAddUpdateEmpolyee.ShowDialog();
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "");
        }
    }
}
