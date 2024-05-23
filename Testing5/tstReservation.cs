using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstReservation
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsReservation Reservation = new clsReservation();
            Assert.IsNotNull(Reservation);
        }
        [TestMethod]
        public void AgePropertyOK()
        {
            clsReservation Reservation = new clsReservation();
            Boolean TestData = true;
            Reservation.Age = TestData;
            Assert.AreEqual(Reservation.Age, TestData);
        }
        [TestMethod]
        public void DateAndTimePropertyOK()
        {
            clsReservation Reservation = new clsReservation();
            DateTime TestData = DateTime.Now.Date;
            Reservation.DateAndTime = TestData;
            Assert.AreEqual(Reservation.DateAndTime, TestData);
        }
        [TestMethod]
        public void ReservationIdPropertyOK()
        {
            clsReservation Reservation = new clsReservation();
            Int32 TestData = 1;
            Reservation.ReservationId = TestData;
            Assert.AreEqual(Reservation.ReservationId, TestData);
        }
        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsReservation Reservation = new clsReservation();
            Int32 TestData = 1;    
            Reservation.CustomerId = TestData;
            Assert.AreEqual(Reservation.CustomerId, TestData);
        }
        [TestMethod]
        public void NamePropertyOK()
        {
            clsReservation Reservation = new clsReservation();
            string TestData = "Md Jobaer Hasan Efaz";
            Reservation.Name = TestData;
            Assert.AreEqual(Reservation.Name, TestData);
        }
        [TestMethod]
        public void PhonePropertyOK()
        {
            clsReservation Reservation = new clsReservation();
            string TestData = "07737279924";
            Reservation.Phone = TestData;
            Assert.AreEqual(Reservation.Phone, TestData);
        }
        [TestMethod]
        public void TableNumberPropertyOK()
        {
            clsReservation Reservation = new clsReservation();
            Int32 TestData = 1;
            Reservation.TableNumber = TestData;
            Assert.AreEqual(Reservation.TableNumber, TestData);
        }
        [TestMethod]
        public void FindeMethodOK()
        {
            //create a instance of the class i wantt to create 
            clsReservation Reservation = new clsReservation();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ReservationId = 2;
            //invoke the method
            Found = Reservation.Find(ReservationId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestReservationIdFound()
        {
            //create an instance of the class we want to create 
            clsReservation Reservation = new clsReservation();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ReservationId = 2;
            //invoke the method
            Found = Reservation.Find(ReservationId);
            //check the reservation id
            if (Reservation.ReservationId != 2)
            {
                OK= false;
            }
            //test to see that result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAndTimeFound()
        {
            clsReservation Reservation = new clsReservation();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReservationId = 2;
            Found = Reservation.Find(ReservationId);
            if (Reservation.DateAndTime != Convert.ToDateTime("27/03/2024"))
            {
                OK= false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsReservation Reservation = new clsReservation();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReservationId = 2;
            Found = Reservation.Find(ReservationId);
            if (Reservation.CustomerId != 1)
            {
                OK= false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNameFound()
        {
            clsReservation Reservation = new clsReservation();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReservationId = 2;
            Found = Reservation.Find(ReservationId);
            if (Reservation.Name != "Efaz")
            {
                OK= false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPhoneFound()
        {
            clsReservation Reservation = new clsReservation();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReservationId = 2;
            Found = Reservation.Find(ReservationId);
            if (Reservation.Phone != "0777728272827")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAgeFound() 
        { 
            clsReservation Reservation = new clsReservation();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReservationId = 2;
            Found = Reservation.Find(ReservationId);
            if (Reservation.Age != true)
            {
                OK= false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTableNumberFound()
        {
            clsReservation Reservation = new clsReservation();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReservationId = 2;
            Found = Reservation.Find(ReservationId);
            if(Reservation.TableNumber != 1)
            {
                OK= false;
            }
            Assert.IsTrue(OK);
        }

    }
}
