using System;
using System.Data;
using System.Data.SqlClient;
using HMS_DataAccessLayer;
namespace HMS_BusinessLayer
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? UserID { private set; get; }
        public int EmployeeID { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }

        public clsUser()

        {
            this.UserID = null;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.IsActive = true;
            Mode = enMode.AddNew;
        }

        private clsUser(int UserID, int EmployeeID, string Username, string Password,
            bool IsActive)

        {
            this.UserID = UserID;
            this.EmployeeID = EmployeeID;
            this.UserName = Username;
            this.Password = Password;
            this.IsActive = IsActive;

            Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            SqlParameter[] sp = new SqlParameter[4];
            sp[0] = new SqlParameter("UserName", this.UserName);
            sp[1] = new SqlParameter("Password", this.Password);
            sp[2] = new SqlParameter("IsActive", this.IsActive);
            sp[3] = new SqlParameter("EmployeeID", this.EmployeeID);
            this.UserID = clsUsersData.AddNewUser(sp);
            return (this.UserID != null);
        }

        private bool _UpdateUser()
        {
            SqlParameter[] sp = new SqlParameter[5];
            sp[0] = new SqlParameter("UserID", this.UserID);
            sp[1] = new SqlParameter("EmployeeID", this.EmployeeID);
            sp[2] = new SqlParameter("UserName", this.UserName);
            sp[3] = new SqlParameter("Password", this.Password);
            sp[4] = new SqlParameter("IsActive", this.IsActive);
            return clsUsersData.UpdateUser(sp);
        }

        public static clsUser Find(int UserID)
        {

            SqlParameter[] sp = new SqlParameter[5];
            sp[0] = new SqlParameter("UserID", UserID);
            sp[1] = new SqlParameter("UserName", null);
            sp[2] = new SqlParameter("Password", null);
            sp[3] = new SqlParameter("IsActive", null);
            sp[4] = new SqlParameter("EmployeeID", null);
            bool IsFound = clsUsersData.FindUser(ref sp);
            if (IsFound)
                return new clsUser((int)sp[0].Value, (int)sp[4].Value, (string)sp[1].Value, (string)sp[2].Value, (bool)sp[3].Value);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();

            }

            return false;
        }

        public static DataTable GetAllUsers()
        {
            return clsUsersData.GetAllUsers();
        }

        public static bool DeleteUser(int UserID)
        {
            SqlParameter sp = new SqlParameter("UserID", UserID);
            
            return clsUsersData.DeleteUser(sp);
        }

        public static bool IsUserExists(int UserID)
        {
            SqlParameter sp = new SqlParameter("UserID", UserID);
            
            return clsUsersData.IsUserExists(sp);
        }

        public static bool IsUsernameExists(string username)
        {
            SqlParameter sp = new SqlParameter("Username", username);

            return clsUsersData.IsUsernameExists(sp);
        }

        public static bool IsUserExistsByEmployeeID(int employeeID)
        {
            SqlParameter sp = new SqlParameter("EmployeeID", employeeID);

            return clsUsersData.IsUserExistsByEmployeeID(sp);
        }

        public static DataTable GetUserInfo(int userID)
        {
            SqlParameter sp = new SqlParameter("UserID", userID);

            return clsUsersData.GetUserInfo(sp);
        }

    }
}
