using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing6
{
    [TestClass]
    public class TstOrdIN
    {



        //good test data
        //private data member for the Reserve property
        string CustID = Convert.ToString(123);
        string Custname = "Tony Chopper";
        string TblNO = Convert.ToString(40);
        string Ordtime = DateTime.Now.ToShortDateString();
        string Total_amt = Convert.ToString(2000);
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //test to see that it exists
            Assert.IsNotNull(AnOrdIN);
        }
        [TestMethod]
        public void ReservePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrdIN.Reserve = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrdIN.Reserve, TestData);
        }
        [TestMethod]
        public void OrdtimePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrdIN.Ordtime = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrdIN.Ordtime, TestData);
        }
        [TestMethod]
        public void Ord_idPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrdIN.Ord_id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrdIN.Ord_id, TestData);
        }
        [TestMethod]
        public void CustIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrdIN.CustID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrdIN.CustID, TestData);
        }
        [TestMethod]
        public void Total_amtPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrdIN.Total_amt = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrdIN.Total_amt, TestData);
        }
        [TestMethod]
        public void TblNOPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrdIN.TblNO = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrdIN.TblNO, TestData);
        }
        [TestMethod]
        public void CustnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //create some test data to assign to the property
            String TestData = " ";
            //assign the data to the property
            AnOrdIN.Custname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrdIN.Custname, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //create Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Ord_id = 6;
            //invoke the method
            Found = AnOrdIN.Find(Ord_id);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrd_idFound()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //create Boolean variable to store the results of the validation
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Ord_id = 6;
            //invoke the method
            Found = AnOrdIN.Find(Ord_id);
            //test to see if the result is true
            if (AnOrdIN.Ord_id != 6)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void OrdtimeFound()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //create Boolean variable to store the results of the validation
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Ord_id = 6;
            //invoke the method
            Found = AnOrdIN.Find(Ord_id);
            //ckeck the Ordtime property
            if (AnOrdIN.Ordtime != Convert.ToDateTime("24/12/2024 00:00:00"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustnameFound()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //create Boolean variable to store the results of the validation
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Ord_id = 6;
            //invoke the method
            Found = AnOrdIN.Find(Ord_id);
            //ckeck the Custname property
            if (AnOrdIN.Custname != "Tony Chopper")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TblNOFound()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //create Boolean variable to store the results of the validation
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Ord_id = 6;
            //invoke the method
            Found = AnOrdIN.Find(Ord_id);
            //ckeck the Custname property
            if (AnOrdIN.TblNO != Convert.ToInt32("2"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustIDFound()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //create Boolean variable to store the results of the validation
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Ord_id = 6;
            //invoke the method
            Found = AnOrdIN.Find(Ord_id);
            //ckeck the CustID property
            if (AnOrdIN.CustID != Convert.ToInt32("20"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Total_amtFound()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //create Boolean variable to store the results of the validation
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Ord_id = 6;
            //invoke the method
            Found = AnOrdIN.Find(Ord_id);
            //ckeck the Total_amt property
            if (AnOrdIN.Total_amt != 80.0000)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ReserveFound()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //create Boolean variable to store the results of the validation
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Ord_id = 6;
            //invoke the method
            Found = AnOrdIN.Find(Ord_id);
            //ckeck its reserve or not
            if (AnOrdIN.Reserve != Convert.ToBoolean("True"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethod()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //string variable to store any error message
            String Error = "";
            //invoke the method 
            Error = AnOrdIN.Valid(CustID, Custname, TblNO, Ordtime, Total_amt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CustnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //string c=variable to store any error message
            String Error = "";
            //create some data to pass the method
            string Custname = "";  //this should trigger an error
                                   //incoke the method 
            Error = AnOrdIN.Valid(CustID, Custname, TblNO, Ordtime, Total_amt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CustnameMin()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //string c=variable to store any error message
            String Error = "";
            //create some data to pass the method
            string Custname = "a";  //this should trigger an error
                                    //incoke the method 
            Error = AnOrdIN.Valid(CustID, Custname, TblNO, Ordtime, Total_amt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CustnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //string c=variable to store any error message
            String Error = "";
            //create some data to pass the method
            string Custname = "aa";  //this should trigger an error
                                     //incoke the method 
            Error = AnOrdIN.Valid(CustID, Custname, TblNO, Ordtime, Total_amt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //string c=variable to store any error message
            String Error = "";
            //create some data to pass the method
            string CustID = "aaaaa";  //this should be okay
                                      //invoke the method 
            Error = AnOrdIN.Valid(CustID, Custname, TblNO, Ordtime, Total_amt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustnameMax()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //string c=variable to store any error message
            String Error = "";
            //create some data to pass the method
            string Custname = "aaaaaa";  //this should be okay
                                         //invoke the method 
            Error = AnOrdIN.Valid(CustID, Custname, TblNO, Ordtime, Total_amt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustnameMid()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //string c=variable to store any error message
            String Error = "";
            //create some data to pass the method
            string Custname = "aaa";  //this should trigger an error
                                      //invoke the method 
            Error = AnOrdIN.Valid(CustID, Custname, TblNO, Ordtime, Total_amt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CustnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //string c=variable to store any error message
            String Error = "";
            //create some data to pass the method
            string Custname = "aaaaaaa";  //this should trigger an error
                                          //incoke the method 
            Error = AnOrdIN.Valid(CustID, Custname, TblNO, Ordtime, Total_amt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CustnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Custname = "";
            Custname = Custname.PadRight(500, 'a');//this should trigger an error
                                                   //incoke the method 
            Error = AnOrdIN.Valid(CustID, Custname, TblNO, Ordtime, Total_amt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustIDMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //string c=variable to store any error message
            String Error = "";
            //create some data to pass the method
            string CustnamID = "";  //this should trigger an error
                                    //incoke the method 
            Error = AnOrdIN.Valid(CustID, Custname, TblNO, Ordtime, Total_amt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CustIDMin()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //string c=variable to store any error message
            String Error = "";
            //create some data to pass the method
            string CustID = "1";  //this should trigger an error
                                  //incoke the method 
            Error = AnOrdIN.Valid(CustID, Custname, TblNO, Ordtime, Total_amt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CustIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //string c=variable to store any error message
            String Error = "";
            //create some data to pass the method
            string CustID = "11";  //this should trigger an error
                                   //incoke the method 
            Error = AnOrdIN.Valid(CustID, Custname, TblNO, Ordtime, Total_amt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //string c=variable to store any error message
            String Error = "";
            //create some data to pass the method
            string CustID = "11111";  //this should be okay
                                      //invoke the method 
            Error = AnOrdIN.Valid(CustID, Custname, TblNO, Ordtime, Total_amt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustIDMax()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //string c=variable to store any error message
            String Error = "";
            //create some data to pass the method
            string CustID = "11111";  //this should be okay
                                      //invoke the method 
            Error = AnOrdIN.Valid(CustID, Custname, TblNO, Ordtime, Total_amt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustIDMid()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //string c=variable to store any error message
            String Error = "";
            //create some data to pass the method
            string CustID = "111";  //this should trigger an error
                                    //invoke the method 
            Error = AnOrdIN.Valid(CustID, Custname, TblNO, Ordtime, Total_amt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CustIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //string c=variable to store any error message
            String Error = "";
            //create some data to pass the method
            string CustID = "1111111";  //this should trigger an error
                                        //incoke the method 
            Error = AnOrdIN.Valid(CustID, Custname, TblNO, Ordtime, Total_amt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CustIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustID = "";
            CustID = CustID.PadRight(500, '1');//this should trigger an error
                                               //incoke the method 
            Error = AnOrdIN.Valid(CustID, Custname, TblNO, Ordtime, Total_amt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrdtimeExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string Ordtime = TestDate.ToString();
            //invoke the method
            Error = AnOrdIN.Valid(CustID, Custname, TblNO, Ordtime, Total_amt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string Ordtime = TestDate.ToString();
            //invoke the method
            Error = AnOrdIN.Valid(CustID, Custname, TblNO, Ordtime, Total_amt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string Ordtime = TestDate.ToString();
            //invoke the method
            Error = AnOrdIN.Valid(CustID, Custname, TblNO, Ordtime, Total_amt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string Ordtime = TestDate.ToString();
            //invoke the method
            Error = AnOrdIN.Valid(CustID, Custname, TblNO, Ordtime, Total_amt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrdIN AnOrdIN = new clsOrdIN();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string Ordtime = TestDate.ToString();
            //invoke the method
            Error = AnOrdIN.Valid(CustID, Custname, TblNO, Ordtime, Total_amt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }
    }
}