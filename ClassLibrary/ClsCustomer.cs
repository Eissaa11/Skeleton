using System;
using System.ComponentModel;

namespace ClassLibrary
{
    public class ClsCustomer
    {
        

        public bool GenderPropertryOK { get; set; }
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
                mOrderdate= value;
            }
        }

        public bool Find(int customerId)
        {
            mCustomerId= 1;
            mFirstName = "ahmed";
            mlastName = "Eissa";
            mEmail = "ahmed@gmail.com";
            mphoneno= 61;
            maddress = "Leicester";
            mOrderdate = Convert.ToDateTime("12/06/2000");
            mGender = true;

            // always return true
            return true;
       
        }
    }
}