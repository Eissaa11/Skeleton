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
        public void CountPropertyOK()
        {
            // crate an instance of class we want to crate
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //crate some test data to assign to the property
            Int32 someCount = 2;
            //assign the data to the proprty
            AllCustomer.Count = someCount;
            //test to see that two values are the same
            Assert.AreEqual(AllCustomer.Count, someCount);

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
        public void TwoRecordspreent()
        {
            // crate an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.Count, 2);
        }
    }
}
