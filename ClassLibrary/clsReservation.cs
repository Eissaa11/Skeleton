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
    }
}