using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tststaffcollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see That exists
            Assert.IsNotNull(AllStaff);
        }
        [TestMethod]
        public void StaffListOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to property
            //in this case the data needs to be a list of objects
            List<clsstaff> TestList = new List<clsstaff>();
            //Add an Item to the List
            //Create the item of test data
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
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        //[TestMethod]
        // public void CountPropertyOK()
        // {
        //create an instance of the class we want to create
        //   clsStaffCollection AllStaff = new clsStaffCollection();
        //create some test data to assign to the property
        // Int32 SomeCount = 2;
        //assign the data to the property
        // AllStaff.Count = SomeCount;
        //test to see that two  values are the same
        //  Assert.AreEqual(AllStaff.Count, SomeCount);
        //}
        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //Create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to asssign to the property
            clsstaff TestStaff = new clsstaff();
            //set the properties of the test object
            TestStaff.Gender = true;
            TestStaff.StaffId = 1;
            TestStaff.Phoneno = 1;
            TestStaff.DOB = DateTime.Now;
            TestStaff.JOD = DateTime.Now;
            TestStaff.FirstName = "Aravind";
            TestStaff.LastName = "Amgoth";
            TestStaff.EmailId = "aa@gmail.com";
            TestStaff.Position = "Admin";
            TestStaff.Salary = 2000m;
            TestStaff.Fulladdress = "Leicester";
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to property
            //in this case the data needs to be a list of objects
            List<clsstaff> TestList = new List<clsstaff>();
            //Add an Item to the List
            //Create the item of test data
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
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
        // [TestMethod]
        //public void twoRecordPresent()
        //{
        //create an instance of the class we want to create
        //  //test to see that the two values are the same
        //Assert.AreEqual(AllStaff.Count, 2);
        //}
        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsstaff TestItem = new clsstaff();
            Int32 PrimaryKey = 0;
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
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffId = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOk()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsstaff TestItem = new clsstaff();
            Int32 PrimaryKey = 0;
            TestItem.Gender = true;
            TestItem.Phoneno = 1;
            TestItem.DOB = DateTime.Now;
            TestItem.JOD = DateTime.Now;
            TestItem.FirstName = "Aravind";
            TestItem.LastName = "Amgoth";
            TestItem.EmailId = "aa@gmail.com";
            TestItem.Position = "Admin";
            TestItem.Salary = 2000m;
            TestItem.Fulladdress = "Leicester";
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffId = PrimaryKey;
            ///////
            ///
            TestItem.Gender = false;
            TestItem.Phoneno = 3;
            TestItem.DOB = DateTime.Now;
            TestItem.JOD = DateTime.Now;
            TestItem.FirstName = "Aravindhh";
            TestItem.LastName = "Amgothhh";
            TestItem.EmailId = "aaaa@gmail.com";
            TestItem.Position = "admin";
            TestItem.Salary = 3000m;
            TestItem.Fulladdress = "Leicestershire";
            AllStaff.ThisStaff = TestItem;
            AllStaff.Update();
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            // Create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // Create an item of test data
            clsstaff TestItem = new clsstaff();
            // Var to store the primary key
            Int32 PrimaryKey = 0;
            // Set its properties
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
            // Assign the data to the property
            AllStaff.ThisStaff = TestItem;
            // Add the record
            PrimaryKey = AllStaff.Add();
            // Set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            // Find the record just added
            AllStaff.ThisStaff.Find(PrimaryKey);
            // Delete the record
            AllStaff.Delete();
            // Try to find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            // Test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByFirstNameMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByFirstName("");
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }
        [TestMethod]
        public void ReportByFirstNameNoneFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByFirstName("xxx xxx");
            Assert.AreEqual(0, FilteredStaff.Count);
        }
        [TestMethod]
        public void ReportByFirstNameTestDataFound()
        {
            clsStaffCollection FilteredFirstName = new clsStaffCollection();
            Boolean OK = true;
            FilteredFirstName.ReportByFirstName("yyy yyy");
            if (FilteredFirstName.Count == 2)
            {
                if (FilteredFirstName.StaffList[0].StaffId != 8)
                {
                    OK = false;
                }
                if (FilteredFirstName.StaffList[1].StaffId != 9)
                {
                    OK = false;
                }
                else
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }
        }
    }
}