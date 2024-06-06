using System;
using System.IO;

namespace ClassLibrary
{
    public class clsStaffUser
    {
        private Int32 mUserId;
        public int UserId
        {
            get
            {
                return mUserId;
            }
            set
            {
                mUserId = value;
            }
        }
        private string mUserName;
        public string UserName
        {
            get
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
            }
        }
        private string mPassword;
        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }
        private string mDepartment;
        public string Department
        {
            get
            {
                return mDepartment;
            }
            set
            {
                mDepartment = value;
            }
        }
        public bool FindUser(string userName, string UserPassword)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Username", userName);
            DB.AddParameter("@Password", UserPassword);
            DB.Execute("tblUser_FindUsernamePW");
            if(DB.Count == 1)
            {
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}