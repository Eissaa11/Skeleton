using System;

namespace ClassLibrary
{
    public class clsReservation
    {
        //private the data number for the reservationid property
        private Int32 mReservationId;
        //reservationid public property
        public Int32 ReservationId
        {
            get
            {
                return mReservationId;
            }
            set
            {
                mReservationId = value;
            }
        }
        private Boolean mAge;
        public bool Age
        {
            get
            {
                return mAge;
            }
            set
            {
                mAge = value;
            }
        }
        private DateTime mDateAndTime;
        public DateTime DateAndTime
        {
            get
            {
                return mDateAndTime;
            }
            set
            {
                mDateAndTime = value;
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
        private string mName;
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        public string mPhone;
        public string Phone
        {
            get
            {
                return mPhone;
            }
            set
            {
                mPhone = value;
            }
        }
        private int mTableNumber;
        public int TableNumber
        {
            get
            {
                return mTableNumber;
            }
            set
            {
                mTableNumber = value;
            }

        }
        public bool Find(int ReservationId)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the reservation id to search for
            DB.AddParameter("@ReservationId", ReservationId);
            //execute the stored procedure
            DB.Execute("tblReservation_FilterByReservationId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the databse to the private data numbers
                mReservationId = Convert.ToInt32(DB.DataTable.Rows[0]["ReservationId"]);
                mDateAndTime = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAndTime"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mPhone = Convert.ToString(DB.DataTable.Rows[0]["Phone"]);
                mAge = Convert.ToBoolean(DB.DataTable.Rows[0]["Age"]);
                mTableNumber = Convert.ToInt32(DB.DataTable.Rows[0]["TableNumber"]);
                //returned that everythinh worked ok
                return true;
            }
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }

        public string Valid( string CustomerId, string Name, string Phone, string DateAndTime, string Age, string TableNumber)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp; 
            //if the name is blank
            if (Name.Length == 0)
            {
                //record the error
                Error = Error + "The Name may not be blank : ";
            }
            if (Name.Length > 50) 
            {
                Error = Error + "The Name must be less than 50 characters : ";
            }
            DateTime DateComp = DateTime.Now.Date;
            try
            {


                //copy the DateAndTime value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateAndTime);
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
            } catch
            {
                Error = Error + "The date was not a valid date :";
            }
            if (Phone.Length == 0)
            {
                Error = Error + "The phone may not be blank : ";
            }
            if (Phone.Length >50)
            {
                Error = Error + "The phone must be less that 50 characters :";
            }
            if (CustomerId.Length ==0)
            {
                Error = Error + "CustomerId may not be blank ;";
            }
            if (CustomerId.Length > 3)
            {
                Error = Error + "CustomerId must be less than 3 charaters :";
            }
            if (TableNumber.Length == 0)
            {
                Error = Error + "Table Number may not be blank ;";
            }
            if (TableNumber.Length > 2)
            {
                Error = Error + "Table Number must be less than 3 charaters :";
            }
            //return any error messages 
            return Error;
        }
    }
}