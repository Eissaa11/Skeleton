using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsReservationCollection
    {
        public clsReservationCollection()
        {
            //object for data connection
            clsDataConnection DB =new clsDataConnection();
            //execute the stored procedure
            DB.Execute("tblReservation_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        List<clsReservation> mReservationList = new List<clsReservation>();
        clsReservation mThisReservation = new clsReservation();
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
        public clsReservation ThisReservation
        {
            get
            {
                return mThisReservation;
            }
            set
            {
                mThisReservation = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Customerid", mThisReservation.CustomerId);
            DB.AddParameter("@Name", mThisReservation.Name);
            DB.AddParameter("@Phone", mThisReservation.Phone);
            DB.AddParameter("@DateAndTime", mThisReservation.DateAndTime);
            DB.AddParameter("@Age", mThisReservation.Age);
            DB.AddParameter("@TableNumber", mThisReservation.TableNumber);
            return DB.Execute("tblReservation_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ReservationId", mThisReservation.ReservationId);
            DB.AddParameter("@CustomerId", mThisReservation.CustomerId);
            DB.AddParameter("@Name", mThisReservation.Name);
            DB.AddParameter("@Phone", mThisReservation.Phone);
            DB.AddParameter("@DateAndTime", mThisReservation.DateAndTime);
            DB.AddParameter("@Age", mThisReservation.Age);
            DB.AddParameter("@TableNumber", mThisReservation.TableNumber);
            DB.Execute("tblReservation_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ReservationId", mThisReservation.ReservationId);
            DB.Execute("tblReservation_Delete");
        }

        public void ReportByName(string Name)
        {
            //filter records based on a full or partial name
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Name", Name);
            DB.Execute("tblReservation_FilterByName");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mReservationList = new List<clsReservation>();
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
    }
}