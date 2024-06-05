using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace Testing4
{
    [TestClass]
    public class tstOrderT
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //test to see that it exists
            Assert.IsNotNull(AnOrderT);
        }
        [TestMethod]
        public void PaidPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrderT.Paid = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderT.Paid, TestData);

        }
        [TestMethod]
        public void Order_IdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderT.Order_Id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderT.Order_Id, TestData);
        }
        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderT.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderT.CustomerId, TestData);

        }
        [TestMethod]
        public void Placed_atPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrderT.Placed_at = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderT.Placed_at, TestData);
        }
        [TestMethod]
        public void FirstnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //create some test data to assign to the property
            string TestData = "First Name";
            //assign the data to the property
            AnOrderT.Firstname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderT.Firstname, TestData);
        }

        [TestMethod]
        public void Total_amountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderT.Total_amount = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderT.Total_amount, TestData);
        }
        [TestMethod]
        public void PhonenoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderT.Phoneno = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderT.Phoneno, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //Create an  instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //create a boolean variable to store the result of the validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 Order_Id = 17;
            //invoke the method
            Found = AnOrderT.Find(Order_Id);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderIdFound()
        {
            //Create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data ia OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Order_Id = 17;
            //invoke the method
            Found = AnOrderT.Find(Order_Id);
            // check the OrderID
            if (AnOrderT.Order_Id != 17)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);



        }
        [TestMethod]
        public void TestPlaced_atFound()
        {
            //Create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data ia OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Order_Id = 17;
            //invoke the method
            Found = AnOrderT.Find(Order_Id);
            // check the date of order placed which is Placd_at

            if (AnOrderT.Placed_at != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPaidFound()
        {
            //Create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data ia OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Order_Id = 17;
            //invoke the method
            Found = AnOrderT.Find(Order_Id);
            // check that order is paid or not  

            if (AnOrderT.Paid != true)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerIdFound()
        {
            //Create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data ia OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 11;
            //invoke the method
            Found = AnOrderT.Find(CustomerId);
            // check the CustmerID
            if (AnOrderT.CustomerId != 11)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPhonenoFound()
        {
            //Create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data ia OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Phoneno = 0123456789;
            //invoke the method
            Found = AnOrderT.Find(Phoneno);
            // check the OrderID
            if (AnOrderT.Phoneno != 0123456789)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstnameFound()
        {
            //Create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //create some test data to assign to the property
            string TestData = "Alex";
            //assign the data to the property
            AnOrderT.Firstname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderT.Firstname, TestData);

        }
        [TestMethod]
        public void TestTotal_amountFound()
        {
            //Create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data ia OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Total_amount = 10;
            //invoke the method
            Found = AnOrderT.Find(Total_amount);
            // check the OrderID
            if (AnOrderT.Total_amount != 10)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }
    }
}

