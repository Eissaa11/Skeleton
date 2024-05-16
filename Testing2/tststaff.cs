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
        [TestMethod]
       public void GenderPropertyOK()
        {
            clsstaff staff = new clsstaff();
            Boolean TestData = true;
            staff.Gender = TestData;
            Assert.AreEqual(staff.Gender, TestData);
        }
        [TestMethod]
        public void DOBPropertyOK()
        {
            clsstaff staff = new clsstaff();
            DateTime TestData = DateTime.Now.Date;
            staff.DOB = TestData;
            Assert.AreEqual(staff.DOB, TestData);
        }
        [TestMethod]
        public void StaffIdPropertyOK()
        {
            clsstaff staff = new clsstaff();
            Int32 TestData = 1;
            staff.StaffId = TestData;
            Assert.AreEqual(staff.StaffId, TestData);
        }
        [TestMethod]
        public void PhonenoPropertyOK()
        {
            clsstaff staff = new clsstaff();
            Int32 TestData = 1;
            staff.Phoneno = TestData;
            Assert.AreEqual(staff.Phoneno, TestData);
        }
        [TestMethod]
        public void EmailIdPropertyOK()
        {
            clsstaff staff = new clsstaff();
            String TestData = "amgoth@gmail.com";
            staff.EmailId = TestData;
            Assert.AreEqual(staff.EmailId, TestData);
        } [TestMethod]
        public void FulladdressPropertyOK()
        {
            clsstaff staff = new clsstaff();
            String TestData = "Leicester";
            staff.Fulladdress = TestData;
            Assert.AreEqual(staff.Fulladdress, TestData);
        }
        [TestMethod]
        public void FirstnamePropertyOK()
        {
            clsstaff staff = new clsstaff();
            String TestData = "Aravind";
            staff.FirstName = TestData;
            Assert.AreEqual(staff.FirstName, TestData);
        }
        [TestMethod]
        public void LastnamePropertyOK()
        {
            clsstaff staff = new clsstaff();
            String TestData = "Amgoth";
            staff.LastName = TestData;
            Assert.AreEqual(staff.LastName, TestData);
        }
        [TestMethod]
        public void PositionPropertyOK()
        {
            clsstaff staff = new clsstaff();
            String TestData = "Admin";
            staff.Position = TestData;
            Assert.AreEqual(staff.Position, TestData);
        }
        [TestMethod]
        public void SalaryPropertyOK()
        {
            clsstaff staff = new clsstaff();
            decimal TestData = 50000m; 
            staff.Salary = TestData;
            Assert.AreEqual(staff.Salary, TestData);
        }
        [TestMethod]
        public void JODPropertyOK()
        {
            clsstaff staff = new clsstaff();
            DateTime TestData = DateTime.Now.Date;
            staff.joiningDate = TestData;
            Assert.AreEqual(staff.joiningDate, TestData);
        }
    }
}
