using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;

namespace Testing4
{
    [TestClass]
    public class tstOrderT
    {
        //good test data
        //create some data to pass the method
        string CustomerId = Convert.ToString(123);
        string Firstname = "Alex";
        string Phoneno = Convert.ToString(1234567890);
        string Total_amount = Convert.ToString(1200);
        string Placed_at = DateTime.Now.ToShortDateString();




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
            //create a boolean variable to record if the data ia OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 Order_Id = 4;
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
            Int32 Order_Id = 4;
            //invoke the method
            Found = AnOrderT.Find(Order_Id);
            // check the OrderID
            if (AnOrderT.Order_Id != 4)
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
            Int32 Order_Id = 4;
            //invoke the method
            Found = AnOrderT.Find(Order_Id);
            // check the date of order placed which is Placd_at

            if (AnOrderT.Placed_at != Convert.ToDateTime("2020-05-23 00:00:00.000"))
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
            Int32 Order_Id = 4;
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
            Int32 Order_Id = 4;
            //invoke the method
            Found = AnOrderT.Find(Order_Id);
            // check the CustmerID
            if (AnOrderT.CustomerId != 15)
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
            Int32 Order_Id = 4;
            //invoke the method
            Found = AnOrderT.Find(Order_Id);
            // check the OrderID
            if (AnOrderT.Phoneno != 2135485165)
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
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data ia OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Order_Id = 4;
            //invoke the method
            Found = AnOrderT.Find(Order_Id);
            //chek the Firstname Property
            if (AnOrderT.Firstname != "sohn")
            {
                OK = false;
            }
            //test to ee the result is correct
            Assert.IsTrue(OK);

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
            Int32 Order_Id = 4;
            //invoke the method
            Found = AnOrderT.Find(Order_Id);
            // check the Total_amount
            if (AnOrderT.Total_amount != 15)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        public void ValidMethodOK()
        {
            //Create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //String variable to store any error message
            string Error = "";
            //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test ot see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMinLessOne()
        {
            //Create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerId = ""; //this should trigger an error
                                    //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CustomerIdMin()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerId = "1"; //this should be ok
                                     //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIdMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerId = "11"; //this should be ok
                                      //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIdMaxLessOne()
        {  //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerId = "9999"; //this should be ok
                                         //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CustomerIdMax()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerId = "99999"; //this should be ok
                                         //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIdMid()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerId = "999"; //this should be ok
                                       //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIdMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerId = "99999+1"; //this should be fail
                                           //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CustomerIdExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerId = "";
            CustomerId = CustomerId.PadRight(50, '1');    //this should be fail  
                                                           //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void FirstnameLessOne()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Firstname = "";
            //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstnameMin()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Firstname = "a";
            //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void FirstnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Firstname = "aa";
            //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Firstname = "";
            Firstname = Firstname.PadRight(49, 'a');
            //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstnameMax()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Firstname = "";
            Firstname = Firstname.PadRight(50, 'a');
            //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void FirstnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string Firstname = "";
            Firstname = Firstname.PadRight(51, 'a');
            //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstnameMid()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Firstname = "";
            Firstname = Firstname.PadRight(25, 'a');
            //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
 public void Placed_atExtremeMin()
 {
     //create an instance of the class we want to create
     clsOrderT AnOrderT = new clsOrderT();
     //string variable to store any error message
     String Error = "";
     //create a variable to store the test date data
     DateTime TestDate;
     //set the date to todays date
     TestDate = DateTime.Now.Date;
     //change the date to whatever the date is less 100 years
     TestDate = TestDate.AddYears(-100);
     //convert the date variable to a string variable
     string Placed_at = TestDate.ToString();
     //invoke the method
     Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
     //test to see that the result is correct
     Assert.AreNotEqual(Error, "");




 }
 [TestMethod]
 public void Placed_atMinLessOne()
 {
     //create an instance of the class we want to create
     clsOrderT AnOrderT = new clsOrderT();
     //string variable to store any error message
     String Error = "";
     //create a variable to store the test date data
     DateTime TestDate;
     //set the date totodays date
     TestDate = DateTime.Now.Date;
     //change the date to whatever the date is less 1 day
     TestDate = TestDate.AddDays(-1);
     //convert the date variable to a string variable
     string Placed_at = TestDate.ToString();
     //invoke the method
     Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
     //test to see that the result is correct
     Assert.AreNotEqual(Error, "");
 }

 [TestMethod]
 public void Placed_atMin()
 {
     //create an instance of the class we want to create
     clsOrderT AnOrderT = new clsOrderT();
     //string variable to store any error message
     String Error = "";
     //create a variable to store the test date data
     DateTime TestDate;
     //set the date totodays date
     TestDate = DateTime.Now.Date;
     //convert the date variable to a string variable
     string Placed_at = TestDate.ToString();
     //invoke the method
     Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
 [TestMethod]
 public void Placed_atMinPlusOne()
 {
     //create an instance of the class we want to create
     clsOrderT AnOrderT = new clsOrderT();
     //string variable to store any error message
     String Error = "";
     //create a variable to store the test date data
     DateTime TestDate;
     //set the date totodays date
     TestDate = DateTime.Now.Date;
     //change the date to whatever the date is plus 1 day
     TestDate = TestDate.AddDays(1);
     //convert the date variable to a string variable
     string Placed_at = TestDate.ToString();
     //invoke the method
     Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
     //test to see that the result is correct
     Assert.AreNotEqual(Error, "");
 }
 [TestMethod]
 public void Placed_atExtremeMax()
 {
     //create an instance of the class we want to create
     clsOrderT AnOrderT = new clsOrderT();
     //string variable to store any error message
     String Error = "";
     //create a variable to store the test date data
     DateTime TestDate;
     //set the date totodays date
     TestDate = DateTime.Now.Date;
     //change the date to whatever the date is plus 100 years
     TestDate = TestDate.AddYears(100);
     //convert the date variable to a string variable
     string Placed_at = TestDate.ToString();
     //invoke the method
     Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
     //test to see that the result is correct
     Assert.AreNotEqual(Error, "");


     }






        [TestMethod]
        public void Placed_atInvalidData()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            String Placed_at = "this is not as date !";
            //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void Total_amountInvalidData()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            String Total_amount = "this is not as date !";
            //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void CustomerIdInvalidData()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            String CustomerId = "this is not as date !";
            //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }



            [TestMethod]
        public void PhonenoMinLessOne()
        {
            //Create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Phoneno = ""; //this should trigger an error
                                 //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PhonenoMin()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Phoneno = "9"; //this should be ok
                                  //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhonenoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Phoneno = "12"; //this should be ok
                                   //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhonenoMaxLessOne()
        {  //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Phoneno = "9999998"; //this should be ok
                                                 //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PhonenoMax()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Phoneno = "99999"; //this should be ok
                                                 //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhonenoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Phoneno = "100000000"; //this should be fail
                                                  //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PhonenoExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Phoneno = "";
            Phoneno = Phoneno.PadRight(50, '1');    //this should be fail  
                                                          //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void Total_amountMinLessOne()
        {
            //Create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Total_amount = ""; //this should trigger an error
                                 //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void Total_amountMin()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Total_amount = "0"; //this should be ok
                                  //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Total_amountMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Total_amount = "1"; //this should be ok
                                   //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void Total_amountMax()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Total_amount = "9999"; //this should be ok
                                                 //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Total_amountMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Phoneno = "100000"; //this should be fail
                                                  //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void Total_amountExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrderT AnOrderT = new clsOrderT();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Total_amount = "";
            Total_amount = Total_amount.PadRight(50, '1');    //this should be fail  
                                                          //invoke the method
            Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
    }
}

