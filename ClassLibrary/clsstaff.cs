using System;

namespace ClassLibrary
{
    public class clsstaff
    {
        private DateTime mjoiningDate;
        public DateTime joiningDate
        {
            get
            {
                return mjoiningDate;
            }
            set
            {
                mjoiningDate = value;
            }
        }
        private Boolean mGender;
        public bool Gender {
            get
            {
                return mGender;
            }
            set
            {
                mGender = value;
            }
                }
        private Int32 mStaffId;
        public Int32 StaffId 
        { 
            get 
            {
                return mStaffId;
            }
            set

            { mStaffId = value;
            }
         }
        private string mEmailId;
        public string EmailId {
            get
            {
                return mEmailId;
            }
            set
            {
                mEmailId = value;
            }
        }
        private string mFulladdress;
        public string Fulladdress {
            get
            {
              return mFulladdress;
            }
            set
            {
               mFulladdress = value;
            }
                }
        private string mFirstName;
        public string FirstName {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
                }
        private string mLastName;
        public string LastName {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
                }
        private string mPosition;
        public string Position {
            get
            {
                return mPosition;
            }
            set
            {
                mPosition = value;
            }
        }
        private Int32 mPhoneno;
        public int Phoneno {
            get
            { 
                return mPhoneno;
            }
            set
            {
                mPhoneno = value;
            } 
                }
        private DateTime mDOB;
        public DateTime DOB {
            get
            {
                return mDOB;
            }
            set
            {
                mDOB = value;
            }
        }
        private decimal mSalary;
        public decimal Salary {
            get
            {
                return mSalary;
            }
            set
            {
                mSalary = value;
            }
                }

        public bool Find(int staffId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procedure
            DB.Execute("tblstaff_FilterBystaffId");
            //If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StffId"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mGender = Convert.ToBoolean(DB.DataTable.Rows[0]["Gender"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mEmailId = Convert.ToString(DB.DataTable.Rows[0]["EmailId"]);
                mjoiningDate = Convert.ToDateTime(DB.DataTable.Rows[0]["joiningDate"]);
                mPhoneno = Convert.ToInt32(DB.DataTable.Rows[0]["Phoneno"]);
                mPosition = Convert.ToString(DB.DataTable.Rows[0]["Position"]);
                mSalary = Convert.ToInt32(DB.DataTable.Rows[0]["Salary"]);
                mFulladdress = Convert.ToString(DB.DataTable.Rows[0]["Fulladdress"]);
                return true;
            }
            //if no records was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }
    }
}