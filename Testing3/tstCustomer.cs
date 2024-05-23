using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomer

    {
        [TestMethod]
        public void InstanceOKc()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Assert.IsNotNull(AnCustomer);
        }
        [TestMethod]
        public void GenderPropertryOK()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Boolean TestData = true;
            AnCustomer.Gender = TestData;
            Assert.AreEqual(AnCustomer.Gender, TestData);
        }
        [TestMethod]
        public void CustomerIdPropertryOK()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Int32 TestData = 1;
            AnCustomer.CustomerId = TestData;
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }
        [TestMethod]
        public void FirstNamePropertryOK()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String TestData = "Ahmed";
            AnCustomer.FirstName = TestData;
            Assert.AreEqual(AnCustomer.FirstName, TestData);
        }
        [TestMethod]
        public void LastNamePropertryOK()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String TestData = "Ahmed";
            AnCustomer.LastName = TestData;
            Assert.AreEqual(AnCustomer.LastName, TestData);
        }
        [TestMethod]
        public void EmailPropertryOK()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String TestData = "Ahmedbahar911@gmail.com";
            AnCustomer.Email = TestData;
            Assert.AreEqual(AnCustomer.Email, TestData);

        }
        [TestMethod]
        public void PhonePropertryOK()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Int32 TestData = 1;
            AnCustomer.phoneno = TestData;
            Assert.AreEqual(AnCustomer.phoneno, TestData);
        }
        [TestMethod]
        public void AddressPropertryOK()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String TestData = "61 canonsligh road";
            AnCustomer.Address = TestData;
            Assert.AreEqual(AnCustomer.Address, TestData);
        }
        [TestMethod]
        public void OrderdetaIdPropertryOK()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            Date TestData = Date;
            AnCustomer.Orderdate = TestData;
            Assert.AreEqual(AnCustomer.Orderdate, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            ClsCustomer AnCustomer = new ClsCustomer();
            //create a Boolean variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to usa with the method
            Int32 CustomerId = 21;
            //invOke the method 
            Found = AnCustomer.find(CustomerId);
            //test to see it if the result is true
            Assert.IsTrue(Found);

        }

    }
  
    
   
    }