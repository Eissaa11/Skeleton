using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

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
            DateTime TestData = DateTime.Now.Date;
            AnCustomer.Orderdate = TestData;
            Assert.AreEqual(AnCustomer.Orderdate, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            ClsCustomer AnCustomer = new ClsCustomer();
            //create a Boolean wariable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerIdFound()
        {
            //Create an instance of the class we want to create
            ClsCustomer AnCustomer = new ClsCustomer();
            //create a Boolean variable to store the result of the validation 
            Boolean Found = false;
            //crate a Boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //create some test data to usa with the method
            Int32 CustomerId = 1;
            //invOke the method 
            Found = AnCustomer.Find(CustomerId);
            //check the address id
            if (AnCustomer.CustomerId != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);



        }
        [TestMethod]
        public void TestfirstnameFound()
        {
            //Create an instance of the class we want to create
            ClsCustomer AnCustomer = new ClsCustomer();
            //create a Boolean variable to store the result of the validation 
            Boolean Found = false;
            //crate a Boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //create some test data to usa with the method
            Int32 CustomerId = 1;
            //invOke the method 
            Found = AnCustomer.Find(CustomerId);
            //check the address id
            if (AnCustomer.FirstName != "Ahmed")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestlastnameFound()
        {
            //Create an instance of the class we want to create
            ClsCustomer AnCustomer = new ClsCustomer();
            //create a Boolean variable to store the result of the validation 
            Boolean Found = false;
            //crate a Boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //create some test data to usa with the method
            Int32 CustomerId = 1;
            //invOke the method 
            Found = AnCustomer.Find(CustomerId);
            //check the address id
            if (AnCustomer.lastname != "Eissa")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);



        }
        [TestMethod]
        public void TestphonenoFound()
        {
            //Create an instance of the class we want to create
            ClsCustomer AnCustomer = new ClsCustomer();
            //create a Boolean variable to store the result of the validation 
            Boolean Found = false;
            //crate a Boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //create some test data to usa with the method
            Int32 CustomerId = 1;
            //invOke the method 
            Found = AnCustomer.Find(CustomerId);
            //check the address id
            if (AnCustomer.phoneno != 1234567890)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);



        }
        [TestMethod]
        public void TestAddressFound()
        {
            //Create an instance of the class we want to create
            ClsCustomer AnCustomer = new ClsCustomer();
            //create a Boolean variable to store the result of the validation 
            Boolean Found = false;
            //crate a Boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //create some test data to usa with the method
            Int32 CustomerId = 1;
            //invOke the method 
            Found = AnCustomer.Find(CustomerId);
            //check the address id
            if (AnCustomer.Address != "61 Cansigth road")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);



        }
        [TestMethod]
        public void TestEmailFound()
        {
            //Create an instance of the class we want to create
            ClsCustomer AnCustomer = new ClsCustomer();
            //create a Boolean variable to store the result of the validation 
            Boolean Found = false;
            //crate a Boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //create some test data to usa with the method
            Int32 CustomerId = 1;
            //invOke the method 
            Found = AnCustomer.Find(CustomerId);
            //check the address id
            if (AnCustomer.Email != "ahmed@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);



        }
        [TestMethod]
        public void TestOrderdateFound()
        {
            //Create an instance of the class we want to create
            ClsCustomer AnCustomer = new ClsCustomer();
            //create a Boolean variable to store the result of the validation 
            Boolean Found = false;
            //crate a Boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //create some test data to usa with the method
            Int32 CustomerId = 1;
            //invOke the method 
            Found = AnCustomer.Find(CustomerId);
            //check the address id
            if (AnCustomer.Orderdate != Convert.ToDateTime("16/05/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);



        }
        [TestMethod]
        public void TestGenderFound()
        {
            //Create an instance of the class we want to create
            ClsCustomer AnCustomer = new ClsCustomer();
            //create a Boolean variable to store the result of the validation 
            Boolean Found = false;
            //crate a Boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //create some test data to usa with the method
            Int32 CustomerId = 1;
            //invOke the method 
            Found = AnCustomer.Find(CustomerId);
            //check the address id
            if (AnCustomer.Gender != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);



        }
    }
}
        

       



        



    
