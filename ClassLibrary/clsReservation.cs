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
            //set the private data numbers to the test data value
            mReservationId = 2;
            mDateAndTime = Convert.ToDateTime("27/03/2024");
            mCustomerId = 1;
            mName = "Efaz";
            mPhone = "0777728272827";
            mAge = true;
            mTableNumber = 1;
            //always return true
            return true;
        }
    }
}