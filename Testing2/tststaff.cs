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
            Int32 TestData = 11;
            staff.StaffId = TestData;
            Assert.AreEqual(staff.StaffId, TestData);
        }
        [TestMethod]
        public void PhonenoPropertyOK()
        {
            clsstaff staff = new clsstaff();
            Int32 TestData = 1234567890;
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
        }
        [TestMethod]
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
            decimal TestData = 2000;
            staff.Salary = TestData;
            Assert.AreEqual(staff.Salary, TestData);
        }
        [TestMethod]
        public void JODPropertyOK()
        {
            clsstaff staff = new clsstaff();
            DateTime TestData = DateTime.Now.Date;
            staff.JOD = TestData;
            Assert.AreEqual(staff.JOD, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsstaff staff = new clsstaff();
            //create a Boolean wariable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffId = 12;
            //invoke the method
            Found = staff.Find(StaffId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsstaff staff = new clsstaff();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 12;
            //invoke the method
            Found = staff.Find(StaffId);
            //check the staff Id
            if (staff.StaffId != 12)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestDOBFound()
        {
            //create an instance of the class we want to create
            clsstaff staff = new clsstaff();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 12;
            //invoke the method
            Found = staff.Find(StaffId);
            //check the staff Id
            if (staff.DOB != Convert.ToDateTime("12/06/2002"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestJODFound()
        {
            //create an instance of the class we want to create
            clsstaff staff = new clsstaff();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 12;
            //invoke the method
            Found = staff.Find(StaffId);
            //check the staff Id
            if (staff.JOD != Convert.ToDateTime("16/06/2025"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestPhonenoFound()
        {
            //create an instance of the class we want to create
            clsstaff staff = new clsstaff();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 12;
            //invoke the method
            Found = staff.Find(StaffId);
            //check the staff Id
            if (staff.Phoneno != 1234567890)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestEmailIdFound()
        {
            //create an instance of the class we want to create
            clsstaff staff = new clsstaff();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 12;
            //invoke the method
            Found = staff.Find(StaffId);
            //check the staff Id
            if (staff.EmailId != "aa@gmail.com")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestFullAddressFound()
        {
            //create an instance of the class we want to create
            clsstaff staff = new clsstaff();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 12;
            //invoke the method
            Found = staff.Find(StaffId);
            //check the staff Id
            if (staff.Fulladdress != "Leicester")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestPositionFound()
        {
            //create an instance of the class we want to create
            clsstaff staff = new clsstaff();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 12;
            //invoke the method
            Found = staff.Find(StaffId);
            //check the staff Id
            if (staff.Position != "Admin")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestSalaryFound()
        {
            //create an instance of the class we want to create
            clsstaff staff = new clsstaff();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 11;
            //invoke the method
            Found = staff.Find(StaffId);
            //check the staff Id
            if (staff.Salary != 2000)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestGenderFound()
        {
            //create an instance of the class we want to create
            clsstaff staff = new clsstaff();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 12;
            //invoke the method
            Found = staff.Find(StaffId);
            //check the staff Id
            if (staff.Gender != true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsstaff staff = new clsstaff();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 12;
            //invoke the method
            Found = staff.Find(StaffId);
            //check the staff Id
            if (staff.FirstName != "Aravind")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class we want to create
            clsstaff staff = new clsstaff();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 12;
            //invoke the method
            Found = staff.Find(StaffId);
            //check the staff Id
            if (staff.LastName != "Amgoth")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);

        }

    }
}