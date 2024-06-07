using System;
using System.Collections.Generic;
using System.Data;
using System.Net;


namespace ClassLibrary
{
   //constructor for the class
    public class clsOrderCollection
    {




        //private data member of the list
        List <clsOrderT> mOrderList = new List<clsOrderT>();

        public List<clsOrderT> OrderList 
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }

            set
            {
                //later;
            }
        }
        public clsOrderT ThisOrder { get; set; }
    }
}

    