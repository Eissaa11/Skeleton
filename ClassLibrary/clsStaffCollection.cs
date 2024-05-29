using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {



        public clsStaffCollection()
        {
            clsstaff TestItem = new clsstaff();
            //set its properties
            TestItem.Gender = true;
            TestItem.StaffId = 1;
            TestItem.Phoneno = 1;
            TestItem.DOB = DateTime.Now;
            TestItem.JOD = DateTime.Now;
            TestItem.FirstName = "Aravind";
            TestItem.LastName = "Amgoth";
            TestItem.EmailId = "aa@gmail.com";
            TestItem.Position = "Admin";
            TestItem.Salary = 2000m;
            TestItem.Fulladdress = "Leicester";
            //add the test item the test list
            mStaffList.Add(TestItem);
            //RE Initialise the object for some new data
            TestItem = new clsstaff();
            //set its properties
            TestItem.Gender = true;
            TestItem.StaffId = 2;
            TestItem.Phoneno = 2;
            TestItem.DOB = DateTime.Now;
            TestItem.JOD = DateTime.Now;
            TestItem.FirstName = "Ara";
            TestItem.LastName = "Amgo";
            TestItem.EmailId = "ara@gmail.com";
            TestItem.Position = "Admi";
            TestItem.Salary = 3000m;
            TestItem.Fulladdress = "Leicestershire";
            //add the item to the test list
            mStaffList.Add(TestItem);
            /////
            ///


        }
        //private data member for the list
        List<clsstaff> mStaffList = new List<clsstaff>();

        public List<clsstaff> StaffList
        {
            get
            {
                //return the private dta
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the private dta
                return mStaffList.Count;
            }
            set
            {

            }
        }
        public clsstaff ThisStaff { get; set; }


    }
}