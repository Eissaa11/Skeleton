using System;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class ClsCustomer
    {
        

        public bool GenderPropertryOK { get; set; }
        public string mEmailId { get; private set; }
        public int mPhoneno { get; private set; }

        private Boolean mGender;

        public string mFulladdress { get; private set; }
        public DateTime mOrderDate { get; private set; }

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
        private Int32 mCustomerId;
        public Int32 CustomerId
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
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
            
        private string mlastName;
        public string LastName 
        {
            get
            {
                return mlastName;
            }
            set
            {
                mlastName = value;
            }
        }
        private string mEmail;
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }
        private Int32 mphoneno;
        public int phoneno
        {
            get
            {
                return mphoneno;
            }
            set
            {
                mphoneno = value;
            }
        }
        private string maddress;
        public string Address
        {
            get
            {
                return maddress;
            }
            set
            {
                maddress = value;
            }
        }

        private DateTime mOrderdate;
        public DateTime Orderdate
        {
            get
            {
                return mOrderdate;
            }
            set
            {
                mOrderdate = value;
            }
        }

        public string lastname { get; set; }
        public object DateAdded { get; set; }

        public bool Find(int CustomerId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@CustomerId", CustomerId);
            //execute the stored procedure
            DB.Execute("Sproc_tblCustomer_FilterByCustomerId");
            //If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mlastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mGender = Convert.ToBoolean(DB.DataTable.Rows[0]["Gender"]);
                mOrderdate = Convert.ToDateTime(DB.DataTable.Rows[0]["Orderdate"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
              
                mphoneno = Convert.ToInt32(DB.DataTable.Rows[0]["phoneno"]);
               
                maddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                return true;
            }
            //if no records was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }

        public string Valid(string firstName, string lastName, string gender, string phoneno, string emailId,  String Orderdate, string fullAddress)
           
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
            DateTime DateComp = DateTime.Now.Date;
            try
            {


                //copy the DateAndTime value to the DateTemp variable
                DateTemp = Convert.ToDateTime(Orderdate);
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

            if (lastName.Length == 0)
            {
                Error = Error + "The lastName may not be blank : ";
            }
            if (lastName.Length > 50)
            {
                Error = Error + "The lastName must be less that 50 characters :";
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
                Error = Error + "emailId Number may not be blank ;";
            }
            if (emailId.Length > 50)
            {
                Error = Error + "emailId Number must be less than 50 charaters :";
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