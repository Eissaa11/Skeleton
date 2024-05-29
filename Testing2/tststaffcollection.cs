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
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllStaff.Count = SomeCount;
            //test to see that two  values are the same
            Assert.AreEqual(AllStaff.Count, SomeCount);
        }
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
        [TestMethod]
        public void twoRecordPresent()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, 2);
        }
    }
}