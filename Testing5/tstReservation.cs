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
    }
}
