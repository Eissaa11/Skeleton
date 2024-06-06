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
    }
}
