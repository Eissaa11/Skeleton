using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
    }
}
