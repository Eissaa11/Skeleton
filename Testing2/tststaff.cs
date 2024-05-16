using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tststaff
    {
        [TestMethod]
        public void InstaneOKc()
        {
            clsstaff staff = new clsstaff();
            Assert.IsNotNull(staff);
        }
    }
}
