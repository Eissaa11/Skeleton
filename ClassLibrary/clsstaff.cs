using System;
using System.Security.Policy;
using System.Xml.Linq;

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
        public string Valid(string firstName, string lastName, string gender, string dOB, string phoneno, string emailId, string jOD, string position, string salary, string fullAddress)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the name is blank
            if (firstName.Length == 0)
            {
                //record the error
                Error = Error + "The FirstName may not be blank : ";
            }
            if (firstName.Length > 50)
            {
                Error = Error + "The firstName must be less than 50 characters : ";
            }
            if (lastName.Length == 0)
            {
                Error = Error + "The lastName may not be blank : ";
            }
            if (lastName.Length > 50)
            {
                Error = Error + "The lastName must be less that 50 characters :";
            }

            DateTime DateComp = DateTime.Now.Date;
            try
            {


                //copy the DateAndTime value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dOB);
                //check to see if the date is less than today's date
                if (DateTemp < DateComp)
                {
                    Error = Error + "The Date cannot be in past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The Date cannot be in the future :";
                }

            }
            catch
            {
                Error = Error + "The Date was not a valid date :";
            }

            if (phoneno.Length == 0)
            {
                Error = Error + "phoneno may not be blank ;";
            }
            if (phoneno.Length > 13)
            {
                Error = Error + "phoneno must be less than 13 charaters :";
            }
            if (emailId.Length == 0)
            {
                Error = Error + "emailId may not be blank ;";
            }
            if (emailId.Length > 50)
            {
                Error = Error + "emailId must be less than 50 charaters :";
            }
            DateTime Datecomp = DateTime.Now.Date;
            try
            {


                //copy the DateAndTime value to the DateTemp variable
                DateTemp = Convert.ToDateTime(jOD);
                //check to see if the date is less than today's date
                if (DateTemp < DateComp)
                {
                    Error = Error + "The Date cannot be in past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The Date cannot be in the future :";
                }

            }
            catch
            {
                Error = Error + "The Date was not a valid date :";
            }

            if (position.Length == 0)
            {
                Error = Error + "position Number may not be blank ;";
            }
            if (position.Length > 50)
            {
                Error = Error + "position Number must be less than 50 charaters :";
            }
            if (salary.Length == 0)
            {
                Error = Error + "salary Number may not be blank ;";
            }
            if (salary.Length > 50)
            {
                Error = Error + "salary Number must be less than 50 charaters :";
            }
            if (fullAddress.Length == 0)
            {
                Error = Error + "fullAddress Number may not be blank ;";
            }
            if (fullAddress.Length > 50)
            {
                Error = Error + "fullAddress Number must be less than 50 charaters :";
            }
            //return any error messages 
            return Error;
        }


    }
}