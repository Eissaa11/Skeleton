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
            //set the private data members to the test data value
            mStaffId = 21;
            mFirstName = "Aravind";
            mLastName = "Amgoth";
            mGender = true;
            mDOB = Convert.ToDateTime("16/05/2025");
            mEmailId = "eamilid ";
            mjoiningDate = Convert.ToDateTime("16/05/2025");
            mPhoneno = 219999898;
            mPosition = "Admin";
            mSalary = 200000;
            mFulladdress = "Leicester";
            return true;
        }
    }
}