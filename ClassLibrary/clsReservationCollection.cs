using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsReservationCollection
    {
        public clsReservationCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB =new clsDataConnection();
            DB.Execute("tblReservation_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsReservation Reservation = new clsReservation();
                Reservation.Age = Convert.ToBoolean(DB.DataTable.Rows[Index]["Age"]);
                Reservation.ReservationId = Convert.ToInt32(DB.DataTable.Rows[Index]["ReservationId"]);
                Reservation.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                Reservation.TableNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["TableNumber"]);
                Reservation.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                Reservation.Phone = Convert.ToString(DB.DataTable.Rows[Index]["Phone"]);
                Reservation.DateAndTime = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAndTime"]);
                mReservationList.Add(Reservation);
                Index++;
            }
        }
        List<clsReservation> mReservationList = new List<clsReservation>();
        public List<clsReservation> ReservationList
        {
            get
            {
                //return the private data
                return mReservationList;
            }
            set
            {
                //set the private data
                mReservationList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mReservationList.Count;
            }
            set
            {

            }
        }
        public clsReservation ThisReservation { get; set; }
    }
}