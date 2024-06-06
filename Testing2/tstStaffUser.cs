using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaffUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffUser User = new clsStaffUser();
            Assert.IsNotNull(User);
        }
        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsStaffUser User = new clsStaffUser();
            Int32 TestData = 1;
            User.UserId = TestData;
            Assert.AreEqual(User.UserId, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsStaffUser User = new clsStaffUser();
            string TestData = "Aravind";
            User.UserName = TestData;
            Assert.AreEqual(User.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsStaffUser User = new clsStaffUser();
            string TestData = "Aravind@123";
            User.Password = TestData;
            Assert.AreEqual(User.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsStaffUser User = new clsStaffUser();
            string TestData = "Staff Manager";
            User.Department = TestData;
            Assert.AreEqual(User.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            clsStaffUser User = new clsStaffUser();
            Boolean Found = false;
            string UserName = "Aravind";
            string Password = "Aravind@123";
            Found = User.FindUser(UserName, Password);
            Assert.IsTrue(Found);
        }
    }
}
