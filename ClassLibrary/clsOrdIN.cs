using System;

namespace ClassLibrary
{
   
    
        public class clsOrdIN
        {
            //private data member for the Reserve property
            private bool mReserve;

            //Reserve public property
            public bool Reserve
            {
                get
                {
                    //this line of code sends data out of the property
                    return mReserve;
                }
                set
                {
                    //this line of code allows data into this property
                    mReserve = value;
                }
            }

            //private data member for the Ordtime property
            private DateTime mOrdtime;
            //Ordtime public property
            public DateTime Ordtime
            {
                get
                {
                    //this line of code sends data out of the property
                    return mOrdtime;
                }
                set
                {
                    //this line of code allows data into this property
                    mOrdtime = value;
                }
            }

            //private data member for the Order id property
            private Int32 mOrd_id;

            //Ord_id public property
            public Int32 Ord_id
            {
                get
                {
                    //this line of code sends data out of the property
                    return mOrd_id;
                }
                set
                {
                    //this line of code allows data into the property
                    mOrd_id = value;

                }
            }

            //private data member for the CustID property
            private Int32 mCustID;

            //CustID public property
            public Int32 CustID
            {
                get
                {
                    //this line of code sends data out of the property
                    return mCustID;
                }
                set
                {
                    //this line of code allows data into the property
                    mCustID = value;
                }
            }


            //private data member for the Total_amt property
            private Int32 mTotal_amt;

            //Total_amt public property
            public Int32 Total_amt
            {
                get
                {
                    //this line of code sends data out of the property
                    return mTotal_amt;
                }

                set
                {
                    //this line of code allows data into the property
                    mTotal_amt = value;
                }

            }


            //private data member for the Order id property
            private string mCustanme;

            //Ord_id public property
            public string Custname
            {
                get
                {
                    //this line of code sends data out of the property
                    return mCustanme;
                }
                set
                {
                    //this line of code allows data into the property
                    mCustanme = value;
                }

            }

            //private data member for the TblNO property
            private Int32 mTblNO;

            //TblNO public property
            public Int32 TblNO
            {
                get
                {
                    //this line of code sends data out of the property
                    return mTblNO;
                }
                set
                {
                    //this line of code allows data into the property
                    mTblNO = value;
                }
            }
        /****** FIND METHOD ******/
        public bool Find(int Ord_id)
        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the paramter for the Ord_id to search for 
            DB.AddParameter("@Ord_id", Ord_id);
            //exucute the stored procedure
            DB.Execute("sproc_OrdIN_FilterByOrd_id");
            //if one recod is found  (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from database to private data members
                mOrd_id = Convert.ToInt32(DB.DataTable.Rows[0]["Ord_id"]);
                mCustID = Convert.ToInt32(DB.DataTable.Rows[0]["CustID"]);
                mTblNO = Convert.ToInt32(DB.DataTable.Rows[0]["TblNO"]);
                mCustanme = Convert.ToString(DB.DataTable.Rows[0]["Custname"]);
                mTotal_amt = Convert.ToInt32(DB.DataTable.Rows[0]["Total_amt"]);
                mOrdtime = Convert.ToDateTime(DB.DataTable.Rows[0]["Ordtime"]);
                mReserve = Convert.ToBoolean(DB.DataTable.Rows[0]["Ord_id"]);

                //return that everything worked OK
                return true;
            }
            //if no record was foumd 
            else
            {
                //return false indicating there is a problem
                return false;
            }



           }
        }
}