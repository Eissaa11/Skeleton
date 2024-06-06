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
            {
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
        /** FIND METHOD **/
        public bool Find(int Order_Id)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@Order_Id", Order_Id);
            //execute the stored procedure
            DB.Execute("sproc_OrderT_FilterByOrder_Id");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {

                //copy the data from the database to the private data members
                mOrder_Id = Convert.ToInt32(DB.DataTable.Rows[0]["Order_Id"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mFirstname = Convert.ToString(DB.DataTable.Rows[0]["Firstname"]);
                mPlaced_at = Convert.ToDateTime(DB.DataTable.Rows[0]["Placed_at"]);
                mPhoneno = Convert.ToInt32(DB.DataTable.Rows[0]["Phoneno"]);
                mPaid = Convert.ToBoolean(DB.DataTable.Rows[0]["Paid"]);
                mTotal_amount = Convert.ToInt32(DB.DataTable.Rows[0]["Total_amount"]);

                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }

        }
    }
}
