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
        //good test data
        //create some test data to pass the method
        string FirstName = "Ali";
        string LastName = "Ahmed";
        string Gender = "Male";
        string Orderdate = DateTime.Now.ToShortDateString();
        string Phoneno = "7440145274";
        string EmailId = "aliahmed911@gmail.com";
        string FullAddress = "leicester";


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
            String TestData = "Ali";
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
            String TestData = "aliahmed911@gmail.com";
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
            String TestData = "leicester";
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
            Int32 CustomerId = 8;
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
            Int32 CustomerId = 8;
            //invOke the method 
            Found = AnCustomer.Find(CustomerId);
            //check the address id
            if (AnCustomer.CustomerId != 8)
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
            Int32 CustomerId = 8;
            //invOke the method 
            Found = AnCustomer.Find(CustomerId);
            //check the address id
            if (AnCustomer.FirstName != "Ali")
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
            Int32 CustomerId = 8;
            //invOke the method 
            Found = AnCustomer.Find(CustomerId);
            //check the address id
            if (AnCustomer.LastName != "Ahmed")
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
            Int32 CustomerId = 8;
            //invOke the method 
            Found = AnCustomer.Find(CustomerId);
            //check the address id
            if (AnCustomer.phoneno != 744014527)
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
            Int32 CustomerId = 8;
            //invOke the method 
            Found = AnCustomer.Find(CustomerId);
            //check the address id
            if (AnCustomer.Address != "leicester")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);



        }
        [TestMethod]
        public void TestEmailFound()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            bool Found = false;
            bool OK = true;
            int CustomerId = 8;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.Email != "aliahmed911@gmail.com")
            {
                OK = false;
            }
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
            Int32 CustomerId = 8;
            //invOke the method 
            Found = AnCustomer.Find(CustomerId);
            //check the address id
            if (AnCustomer.Orderdate != Convert.ToDateTime("29/12/2024"))
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
            Int32 CustomerId = 8;
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
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class i want to create 
            ClsCustomer AnCustomer = new ClsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class i want to create
            ClsCustomer AnCustomer = new ClsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            //test to see that th reult is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMin()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String Error = "";
            string FirstName = "e";
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String Error = "";
            string FirstName = "ee";
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String Error = "";
            string FirstName = "eeeee";
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void FirstNameMax()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String Error = "";
            string FirstName = "eeeeee";
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMid()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String Error = "";
            string FirstName = "eee";
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String Error = "";
            string FirstName = new string('e', 51);
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameExtremeMax()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'e');
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMinLessOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String Error = "";
            string LastName = ""; //this should trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMin()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String Error = "";
            string LastName = "a"; //this should trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMinPlusOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String Error = "";
            string LastName = "aa"; //this should trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxLessOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String Error = "";
            string LastName = "aaaaa"; //this should trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMax()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String Error = "";
            string LastName = "aaaaaa"; //this should trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMid()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String Error = "";
            string LastName = "aaa"; //this should trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string LastName = new string('a', 51); // This should trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameExtremeMax()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string LastName = new string('a', 500); // This should trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreNotEqual(Error, "");





        }
        [TestMethod]
        public void PhonenoMinLessOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String Error = "";
            string Phoneno = ""; //this should trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhonenoMin()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Phoneno = "a"; // This should not trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhonenoMinPlusOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Phoneno = "aa"; // This should not trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhonenoMaxLessOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Phoneno = "aaaaa"; // This should not trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhonenoMax()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Phoneno = "aaaaaa"; // This should not trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhonenoMid()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Phoneno = "aaa"; // This should not trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhonenoMaxPlusOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Phoneno = "aaaaaaaa"; // This should trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhonenoExtremeMax()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string Phoneno = new string('a', 500); // This should trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        ///////
        ///
        [TestMethod]
        public void EmailIdMinLessOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string EmailId = ""; // Empty email address
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "The EmailId may not be blank: ");
        }

        [TestMethod]
        public void EmailIdMin()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string EmailId = "a"; // This should not trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailIdMinPlusOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string EmailId = "aa"; // This should not trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailIdMaxLessOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string EmailId = "aaaaa"; // This should not trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailIdMax()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string EmailId = "aaaaaa"; // This should not trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailIdMid()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string EmailId = "aaa"; // This should not trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailIdMaxPlusOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            //Create an email address longer than 50 characters
            string EmailId = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate , FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        ///////
        ///
        [TestMethod]
        public void FullAddressMinLessOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            String Error = "";
            string FullAddress = ""; //this should trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FullAddressMin()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string FullAddress = "a"; // This should not trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullAddressMinPlusOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string FullAddress = "aa"; // This should not trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullAddressMaxLessOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string FullAddress = "aaaaa"; // This should not trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullAddressMax()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string FullAddress = "aaaaaa"; // This should not trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullAddressMid()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string FullAddress = "aaa"; // This should not trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullAddressMaxPlusOne()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string FullAddress = new string('a', 51); // This should trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullAddressExtremeMax()
        {
            ClsCustomer AnCustomer = new ClsCustomer();
            string Error = "";
            string FullAddress = new string('a', 500); // This should trigger an error
            Error = AnCustomer.Valid(FirstName, LastName, Gender, Phoneno, EmailId, Orderdate, FullAddress);
            Assert.AreNotEqual(Error, "");
        }


    }
}
    



    
