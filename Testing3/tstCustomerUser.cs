using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomerUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerUser User = new clsCustomerUser();
            Assert.IsNotNull(User);
        }
        [TestMethod]
        public void UserIdPropertyOk()
        {
            clsCustomerUser User = new clsCustomerUser();
            Int32 TestData = 1;
            User.UserId = TestData;
            Assert.AreEqual(User.UserId, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOk() 
        {
            clsCustomerUser User = new clsCustomerUser();
            string TestData = "efaz";
            User.UserName = TestData;
            Assert.AreEqual(User.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOk() 
        {
            clsCustomerUser User = new clsCustomerUser();
            string TestData = "1234";
            User.Password = TestData;
            Assert.AreEqual(User.Password, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            clsCustomerUser User = new clsCustomerUser();
            Boolean Found = false;
            string UserName = "efaz";
            string Password = "1234";
            Found = User.FindUser(UserName, Password);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUserNameFound()
        {
            clsCustomerUser User = new clsCustomerUser();
            Boolean Found = false;
            Boolean OK = true;
            string UserName = "efaz";
            string Password = "1234";
            Found = User.FindUser(UserName, Password);
            if (User.UserName !=UserName && User.Password != Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
