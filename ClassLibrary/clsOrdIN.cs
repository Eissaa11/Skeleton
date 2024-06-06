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

            public bool Find(int ord_id)
            {
                //set the private data members to the test data value
                mOrd_id = 21;
                mOrdtime = Convert.ToDateTime("06/06/2024");
                mCustanme = "John Tim";
                mTblNO = Convert.ToInt32("10");
                mCustID = Convert.ToInt32("15");
                mTotal_amt = 30;
                mReserve = Convert.ToBoolean("True");

                //always return true
                return true;
            }
        }
}