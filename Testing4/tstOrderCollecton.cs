using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollecton

    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);

        }
        [TestMethod]

        public void OrderListOk()

        {

            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();

            //create some test data to assign to the property

            //in this case the data needs to be a list of objects
            List<clsOrderT> TestList = new List<clsOrderT>();

            //Add an Item to the List

            //create the item of test data

            clsOrderT TestItem = new clsOrderT();

            //set its properties
            TestItem.Paid = true;

            TestItem.Order_Id = 1;

            TestItem.CustomerId = 1;

            TestItem.Placed_at = DateTime.Now;

            TestItem.Firstname = "sam";

            TestItem.Phoneno = 1234567890;


            TestItem.Total_amount = 10;

            //add the item to the test list

            TestList.Add(TestItem);

            //assign the data to the proprty

            AllOrders.OrderList = TestList;

            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        
        [TestMethod]
        public void ThisOrderPropertyOK()

        {

        //create an instance of the class we want to create

        clsOrderCollection AllOrders = new clsOrderCollection();

        //create some test data to assign to the property

        clsOrderT TestOrder = new clsOrderT();
            //set the properties of the test object

            TestOrder.Paid = true;

            TestOrder.Order_Id = 1;

            TestOrder.CustomerId = 1;

            TestOrder.Placed_at =DateTime.Now;

            TestOrder.Firstname = "sam";

            TestOrder.Phoneno = 1234567890;

            TestOrder.Total_amount = 10;

            //assign the data to the proprty TestAddress;

            AllOrders.ThisOrder = TestOrder;
               // test to see that the two values are the same
                Assert.AreEqual(AllOrders.ThisOrder, TestOrder);

        }

        [TestMethod]



        public void ListAndCountOK()

        {

            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();

            //create some test data to assign to the property

            //in this case the data needs to be a list of objects
            List<clsOrderT> TestList = new List<clsOrderT>();

            //Add an Item to the List

            //create the item of test data

            clsOrderT TestItem = new clsOrderT();

            //set its properties

            TestItem.Paid = true;

            TestItem.Order_Id = 1;

            TestItem.CustomerId = 1;

            TestItem.Placed_at = DateTime.Now;

            TestItem.Firstname = "sam";

            TestItem.Total_amount = 10;

            TestItem.Phoneno = 1234567890;


            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to te property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
       

    }
}
