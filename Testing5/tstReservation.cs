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
    }
}
