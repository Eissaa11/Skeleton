using System;
using System.Collections.Generic;
using System.Data;

namespace ClassLibrary
{
    public class clsStaffCollection
    {



        public clsStaffCollection()
        {
            //variable for the index
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("staff_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsstaff staff = new clsstaff();
                staff.Gender = Convert.ToBoolean(DB.DataTable.Rows[Index]["Gender"]);
                staff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                staff.Phoneno = Convert.ToInt32(DB.DataTable.Rows[Index]["Phoneno"]);
                staff.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                staff.JOD = Convert.ToDateTime(DB.DataTable.Rows[Index]["JOD"]);
                staff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                staff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                staff.EmailId = Convert.ToString(DB.DataTable.Rows[Index]["EmailId"]);
                staff.Position = Convert.ToString(DB.DataTable.Rows[Index]["Position"]);
                staff.Salary = Convert.ToDecimal(DB.DataTable.Rows[Index]["Salary"]);
                staff.Fulladdress = Convert.ToString(DB.DataTable.Rows[Index]["FUllAddress"]);
                mStaffList.Add(staff);
                Index++;

            }
        }
        //private data member for the list
        List<clsstaff> mStaffList = new List<clsstaff>();
        clsstaff mThisStaff = new clsstaff();
        public List<clsstaff> StaffList
        {
            get
            {
                //return the private dta
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the private dta
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsstaff ThisStaff 
        {
            get
            {
                return mThisStaff;
            }
            set
            {
              mThisStaff = value;
            }
        }
        public int Add()
        {
           clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@DOB", mThisStaff.DOB);
            DB.AddParameter("@Gender", mThisStaff.Gender);
            DB.AddParameter("@Phoneno", mThisStaff.Phoneno);
            DB.AddParameter("@JOD", mThisStaff.JOD);
            DB.AddParameter("@EmailId", mThisStaff.EmailId);
            DB.AddParameter("@Position", mThisStaff.Position);
            DB.AddParameter("@FullAddress", mThisStaff.Fulladdress);
            DB.AddParameter("@Salary", mThisStaff.Salary);
            return DB.Execute("tblStaff_Insert");
        }


    }
}