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
        // Valid method to validate customer data
        public string Valid(string firstName, string lastName, string gender, string phoneno, string emailId, string orderdate, string fullAddress)
        {
            string error = "";

            // FirstName validation
            if (firstName.Length == 0)
            {
                error += "The FirstName may not be blank: ";
            }
            if (firstName.Length > 50)
            {
                error += "The FirstName must be less than 50 characters: ";
            }
            // LastName validation
            if (lastName.Length == 0)
            {
                error += "The LastName may not be blank: ";
            }
            if (lastName.Length > 50)
            {
                error += "The LastName must be less than 50 characters: ";
            }

            // Gender validation
            if (gender != "Male" && gender != "Female" && gender != "Other")
            {
                error += "The Gender must be either 'Male', 'Female', or 'Other': ";
            }

            // PhoneNo validation
            if (phoneno.Length == 0)
            {
                error += "The PhoneNo may not be blank: ";
            }
            if (phoneno.Length > 50)
            {
                error += "The PhoneNo must be less than 50 characters: ";
            }

            // EmailId validation
            if (emailId.Length == 0)
            {
                error += "The EmailId may not be blank: ";
            }
            if (emailId.Length > 50)
            {
                error += "The EmailId must be less than 50 characters: ";
            }

            // Orderdate validation
            DateTime tempDate;
            if (!DateTime.TryParse(orderdate, out tempDate))
            {
                error += "The Orderdate is not a valid date: ";
            }

            // FullAddress validation
            if (fullAddress.Length == 0)
            {
                error += "The FullAddress may not be blank: ";
            }
            if (fullAddress.Length > 50)
            {
                error += "The FullAddress must be less than 50 characters: ";
            }

            return error;
        }
    }
}