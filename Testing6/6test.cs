using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class TstOrdIN
    {
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
            Assert.AreEqual(AnOrdIN.Total_amt, TestData) ;
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
    }
}
