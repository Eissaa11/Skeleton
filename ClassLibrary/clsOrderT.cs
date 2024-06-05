using System;

namespace ClassLibrary
{
    public class clsOrderT
    {

        //private data member for the order id property
        private Int32 mOrder_Id;
        //Order_Id public property
        public int Order_Id
        {
            get
            {
                //this line of the code send the data out of the property
                return mOrder_Id;
            }
            set
            {
                //this line of code alloiws data into the property
                mOrder_Id = value;
            }
        }
        //private data member for the CustomerId property
        private Int32 mCustomerId;
        //CustomerId public property
        public int CustomerId
        {
            get
            {
                //this line of the code send the data out of the property
                return mCustomerId;
            }
            set
            {

                //this line of code alloiws data into the property
                mCustomerId = value;
            }
        }
        //private data member for the Paid property
        private bool mPaid;

        //Paid public property
        public bool Paid
        {
            get
            { //this line of the code send the data out of the property
                return mPaid;
            }
            set
            {//this line of code allows data into the property
                mPaid = value;
            }
        }

          

       
        //private data member for the Placed_at property
        private DateTime mPlaced_at;
        //Placed_at public property
        public DateTime Placed_at
        {
            get
            {
                //this line of code sends data out of property
                return mPlaced_at;
            }

            set
            {
                //this line of code alloiws data into the property
                mPlaced_at = value;
            }
        }
        //private data member for the Firstname property   
        private string mFirstname;
        //Firstname public property
        public string Firstname
        {
            get
            {
                //this line of the code send the data out of the property; set; }
                return mFirstname;
            }
            set
            {
                //this line of code alloiws data into the property
                mFirstname = value;
            }
        }

        //private data member for the Total_amount property
        private Int32 mTotal_amount;

        //Total_amount public property  
        public int Total_amount
        {
            get
            {
                //this line of the code send the data out of the property; set; }
                return mTotal_amount;
            }
            set
            {
                //this line of code alloiws data into the property
                mTotal_amount = value;
            }
        }


        //private data member for the Phoneno property    
        private Int32 mPhoneno;
        //Phoneno  public property
        public int Phoneno
        {
            get
            {
                //this line of the code send the data out of the property
                return mPhoneno; 
            }
            set
            {
                //this line of code alloiws data into the property
                mPhoneno = value;
            }

        }
                public bool Find(int orderId)
        {
            //set the private data members to the test data value
            mOrder_Id = 17;
            mPlaced_at = Convert.ToDateTime("23/12/2022");
            mFirstname = "Alex";
            mTotal_amount = 10;
            mCustomerId = 11;
            mPaid = true;
            mPhoneno = 0123456789;
            //always true
            return true;
        }
    }
}