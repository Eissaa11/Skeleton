using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomer);
        }
        [TestMethod]
        public void CustomerListOk()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            List<ClsCustomer> TestList = new List<ClsCustomer>();
            ClsCustomer TestItem = new ClsCustomer();
            TestItem.Gender = true;
            TestItem.CustomerId = 1;
            TestItem.FirstName = "Ahmed";
            TestItem.LastName = "Ahmed";
            TestItem.Email = "Ahmed@gmail.com";
            TestItem.phoneno = 123444;
            TestItem.Orderdate = DateTime.Now;
            TestItem.Address = "Leicester";
            TestList.Add(TestItem);
            AllCustomer.CustomerList = TestList;
            Assert.AreEqual(AllCustomer.CustomerList[0], TestItem);

        }
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            ClsCustomer TestCustomer = new ClsCustomer();
            TestCustomer.Gender = true;
            TestCustomer.CustomerId = 1;
            TestCustomer.FirstName = "Ahmed";
            TestCustomer.LastName = "Ahmed";
            TestCustomer.Email = "Ahmed@gmail.com";
            TestCustomer.phoneno = 123444;
            TestCustomer.Orderdate = DateTime.Now;
            TestCustomer.Address = "Leicester";
            AllCustomer.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);

        }
        [TestMethod]
        public void ListAndCountOK()

        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to property
            //in this case the data needs to be a list of objects
            List<ClsCustomer> TestList = new List<ClsCustomer>();
            //Add an Item to the List
            //Create the item of test data
            ClsCustomer TestItem = new ClsCustomer();
            //set its properties
            TestItem.Gender = true;
            TestItem.CustomerId = 1;
            TestItem.phoneno = 123444;
            TestItem.Orderdate = DateTime.Now;
            TestItem.FirstName = "Ahmed";
            TestItem.LastName = "Ahmed";
            TestItem.Email = "hmed@gmail.com";
            TestItem.Address = "Leicester";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            // create an  instance of the class we want to create
            clsCustomerCollection AllCustomeres = new clsCustomerCollection();
            // crate the item of test data
            ClsCustomer TestItem = new ClsCustomer();
            //varible to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Gender = true;
            TestItem.CustomerId = 1;
            TestItem.phoneno = 123444;
            TestItem.Orderdate = DateTime.Now;
            TestItem.FirstName = "Ahmed";
            TestItem.LastName = "Ahmed";
            TestItem.Email = "hmed@gmail.com";
            TestItem.Address = "Leicester";
            //set thisCustomer to the test data
            AllCustomeres.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomeres.Add();
            //set the primary ket of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomeres.ThisCustomer.Find(PrimaryKey);
            //test to see that the tow values are the same
            Assert.AreEqual(AllCustomeres.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            // create an  instance of the class we want to create
            clsCustomerCollection AllCustomeres = new clsCustomerCollection();
            // crate the item of test data
            ClsCustomer TestItem = new ClsCustomer();
            //varible to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Gender = true;
            TestItem.CustomerId = 1;
            TestItem.phoneno = 123444;
            TestItem.Orderdate = DateTime.Now;
            TestItem.FirstName = "Ahmed";
            TestItem.LastName = "Ahmed";
            TestItem.Email = "hmed@gmail.com";
            TestItem.Address = "Leicester";
            //set thisCustomer to the test data
            AllCustomeres.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomeres.Add();
            //set the primary ket of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomeres.ThisCustomer.Find(PrimaryKey);
            // modify the test record
            TestItem.Gender = false;
            TestItem.CustomerId = 2;
            TestItem.phoneno = 2345;
            TestItem.Orderdate = DateTime.Now;
            TestItem.FirstName = "Maka";
            TestItem.LastName = "Doowd";
            TestItem.Email = "maka@gmail.com";
            TestItem.Address = "Leicester";
            //set thisCustomer to the test data
            AllCustomeres.ThisCustomer = TestItem;
            //Update the record
            AllCustomeres.Update();
            PrimaryKey = AllCustomeres.Add();
            //find the record
            AllCustomeres.ThisCustomer.Find(PrimaryKey);
            // test to see if Thiscustomer matches the test data
            Assert.AreEqual(AllCustomeres.ThisCustomer, TestItem);



        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            // Create an instance of the customer collection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            ClsCustomer TestItem = new ClsCustomer();
            Int32 PrimaryKey = 0;

            // Set properties of the test item
            TestItem.Gender = true;
            TestItem.CustomerId = 1;
            TestItem.phoneno = 123444;
            TestItem.Orderdate = DateTime.Now;
            TestItem.FirstName = "Ahmed";
            TestItem.LastName = "Ahmed";
            TestItem.Email = "ahmed@gmail.com";
            TestItem.Address = "Leicester";

            // Set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;

            // Add the record
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerId = PrimaryKey;

            // Find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);

            // Delete the record
            AllCustomers.Delete();

            // Verify the record has been deleted
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByFirstNameMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            FilteredCustomer.ReportByFirstName("");
            Assert.AreEqual(AllCustomer.Count, FilteredCustomer.Count);
        }
        [TestMethod]
        public void ReportByFirstNameNoneFound()
        {
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            FilteredCustomer.ReportByFirstName("xxx xxx");
            Assert.AreEqual(0, FilteredCustomer.Count);
        }
        [TestMethod]
        public void ReportByFirstNameTestDataFound()
        {
            clsCustomerCollection FilteredFirstName = new clsCustomerCollection();
            Boolean OK = true;
            FilteredFirstName.ReportByFirstName("yyy yyy");
            if (FilteredFirstName.Count == 2)
            {
                if (FilteredFirstName.CustomerList[0].CustomerId != 8)
                {
                    OK = false;
                }
                if (FilteredFirstName.CustomerList[1].CustomerId != 9)
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
