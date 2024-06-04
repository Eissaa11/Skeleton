using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            AnOrderT.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderT.Active, TestData);

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
            AnOrderT.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderT.DateAdded, TestData);
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
        public void phonenoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderT.phoneno = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderT.phoneno, TestData);
        }

        
        
    }
}
