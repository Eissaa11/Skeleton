﻿using System;
using System.Collections.Generic;
using System.Net;
namespace ClassLibrary

{
    //constructor for the class
    public class clsCustomerCollection
    {

        public clsCustomerCollection()
        {
            //variable for the index
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                ClsCustomer Customer = new ClsCustomer();
                Customer.Gender = Convert.ToBoolean(DB.DataTable.Rows[Index]["Gender"]);
                Customer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                Customer.phoneno = Convert.ToInt32(DB.DataTable.Rows[Index]["Phoneno"]);
                Customer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                Customer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                Customer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                Customer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                Customer.Orderdate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                mCustomerlist.Add(Customer);
                Index++;

            }



        }
        //private data member for the list 
        List<ClsCustomer> mCustomerlist = new List<ClsCustomer>();
        //private member data for thisCustomer
        ClsCustomer mThisCustomer = new ClsCustomer();
        public List<ClsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerlist;
            }
            set
            {
                //set the private data
                mCustomerlist = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerlist.Count;

            }

            set
            {
                // we shall worry about this later
            }
        }
        public ClsCustomer ThisCustomer
        {
            get
            {
                // return the private data
                return mThisCustomer;
            }

            set
            {
                //set the private data
                mThisCustomer = value;

            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Firstname", mThisCustomer.FirstName);
            DB.AddParameter("@Lastname", mThisCustomer.LastName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@phoneno", mThisCustomer.phoneno);
            DB.AddParameter("@Gender", mThisCustomer.Gender);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Orderdate", mThisCustomer.Orderdate);

            // execute the Query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@Firstname", mThisCustomer.FirstName);
            DB.AddParameter("@Lastname", mThisCustomer.LastName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@phoneno", mThisCustomer.phoneno);
            DB.AddParameter("@Gender", mThisCustomer.Gender);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Orderdate", mThisCustomer.Orderdate);

            // execute the Query returning the primary key value
            DB.Execute("sproc_tblCustomer_Update");

        }
    }
    

       
    
}