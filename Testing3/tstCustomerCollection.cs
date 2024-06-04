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
            AllCustomer.CustomerList = TestItem;
            Assert.AreEqual(AllCustomer.CustomerList, TestItem);

        }
    }
}
