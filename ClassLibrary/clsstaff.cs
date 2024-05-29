using System;

namespace ClassLibrary
{
    public class clsstaff
    {

        private DateTime mJOD;
        public DateTime JOD
        {
            get
            {
                return mJOD;
            }
            set
            {
                mJOD = value;
            }
        }
        private Boolean mGender;
        public bool Gender
        {
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

            {
                mStaffId = value;
            }
        }
        private string mEmailId;
        public string EmailId
        {
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
        public string Fulladdress
        {
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
        public string FirstName
        {
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
        public string LastName
        {
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
        public string Position
        {
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
        public int Phoneno
        {
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
        public DateTime DOB
        {
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
        public decimal Salary
        {
            get
            {
                return mSalary;
            }
            set
            {
                mSalary = value;
            }
        }

        public bool Find(int StaffId)
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
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mGender = Convert.ToBoolean(DB.DataTable.Rows[0]["Gender"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mEmailId = Convert.ToString(DB.DataTable.Rows[0]["EmailId"]);
                mJOD = Convert.ToDateTime(DB.DataTable.Rows[0]["JOD"]);
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
        public string Valid(string firstName, string lastName, string gender, string dOB, string emailId, string jOD, string phoneno, string position, string salary, string fullAddress)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temparary vaariable to store the data values
            DateTime DateTemp;

            // Validation for FirstName
            if (firstName.Length == 0)
            {
                Error += "The FirstName may not be blank: ";
            }
            if (firstName.Length > 50)
            {
                Error += "The FirstName must be less than 50 characters: ";
            }

            // Validation for LastName
            if (lastName.Length == 0)
            {
                Error += "The LastName may not be blank: ";
            }
            if (lastName.Length > 50)
            {
                Error += "The LastName must be less than 50 characters: ";
            }

            // Validation for FirstName
            if (phoneno.Length == 0)
            {
                Error += "The FirstName may not be blank: ";
            }
            if (phoneno.Length > 13)
            {
                Error += "The FirstName must be less than 50 characters: ";
            }

            // Validation for EmailId
            if (emailId.Length == 0)
            {
                Error += "The EmailId may not be blank: ";
            }
            if (emailId.Length > 60)
            {
                Error += "The EmailId must be less than 50 characters: ";
            }

            // Validation for Position
            if (position.Length == 0)
            {
                Error += "The Position may not be blank: ";
            }
            if (position.Length > 50)
            {
                Error += "The Position must be less than 50 characters: ";
            }

            // Validation for Salary
            if (salary.Length == 0)
            {
                Error += "The Salary may not be blank: ";
            }
            if (salary.Length > 50)
            {
                Error += "The Salary must be less than 50 characters: ";
            }

            // Validation for FullAddress
            if (fullAddress.Length == 0)
            {
                Error += "The FullAddress may not be blank: ";
            }
            if (fullAddress.Length > 50)
            {
                Error += "The FullAddress must be less than 50 characters: ";
            }

            // Validate Date of Birth (DOB)
            if (!DateTime.TryParse(dOB, out DateTemp))
            {
                Error += "Invalid Date of Birth format. Please enter a valid date.";
            }
            else
            {
                // Check if Date of Birth is in the past
                if (DateTemp < DateTime.Now.Date)
                {
                    Error += "The Date of Birth cannot be in the past.";
                }
            }

            //return any error message
            return Error;
        }

    }
}