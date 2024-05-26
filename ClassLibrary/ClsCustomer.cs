﻿using System;
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

        public string mLastName { get; private set; }

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
    
    public bool Find(int CustomerId)
    {
        //create an instance of the data connection 
        clsDataConnection DB = new clsDataConnection();
        //add the parameter for the reservation id to search for
        DB.AddParameter("@Customer", CustomerId);
        //execute the stored procedure
        DB.Execute("tblCustomer_FilterCustomerId");
        //if one record is found (there should be either one or zero)
        if (DB.Count == 1)
        {
            //copy the data from the databse to the private data numbers
            mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
            mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
            mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
            mEmailId = Convert.ToString(DB.DataTable.Rows[0]["EmailId"]);
            mPhoneno = Convert.ToInt32(DB.DataTable.Rows[0]["Phoneno"]);
            mGender = Convert.ToBoolean(DB.DataTable.Rows[0]["Gender"]);
            mFulladdress = Convert.ToString(DB.DataTable.Rows[0]["Fulladdress"]);
            mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAndTime"]);

                //returned that everythinh worked ok
                return true;
        }
        else
        {
            //return false indicating there is a problem
            return false;
        }
    }
}
}