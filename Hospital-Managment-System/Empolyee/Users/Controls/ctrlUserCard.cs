using HMS_BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hospital_Managment_System.Empolyee.Users.Controls
{
    public partial class ctrlUserCard : UserControl
    {
        public ctrlUserCard()
        {
            InitializeComponent();
        }


        public void Reset()
        {
            lblUserID.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblFullName.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblPhone.Text = "[????]";
            lblEmail.Text = "[????]";
            lblNationality.Text = "[????]";
            lblGender.Text = "[????]";
            lblUsername.Text = "[????]";
            lblIsActive.Text = "[????]";
        }

        public bool LoadUserInfo(int UserID)
        {
            DataRow UserInfo = clsUser.GetUserInfo(UserID).Rows[0];

            if (UserInfo != null)
            {
                lblUserID.Text = UserInfo["UserID"].ToString();
                lblNationalNo.Text = UserInfo["NationalNo"].ToString();
                lblFullName.Text = UserInfo["FullName"].ToString();
                lblDateOfBirth.Text = ((DateTime)UserInfo["DateOfBirth"]).ToLongDateString();
                lblPhone.Text = UserInfo["Phone"].ToString();
                lblEmail.Text = UserInfo["Email"].ToString();
                lblNationality.Text = UserInfo["Nationality"].ToString();
                lblGender.Text = UserInfo["Gender"].ToString();
                lblUsername.Text = UserInfo["Username"].ToString();
                lblIsActive.Text = UserInfo["IsActive"].ToString();

                return true;
            }
            else
                return false;

        }

    }
}
