using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Policy;

namespace Testing2
{
    [TestClass]
    public class tststaff
    {
        //good test data
        //create some test data to pass the method
        string FirstName = "Aravind";
        string LastName = "Amgoth";
        string Gender = "Male";
        string DOB = DateTime.Now.ToShortDateString();
        string Phoneno = "1234567890m";
        string EmailId = "amgoth@gmail.com";
        string JOD = DateTime.Now.ToShortDateString();
        string Position = "Admin";
        string Salary = "2000m";
        string FullAddress = "Leicester";



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
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class i want to create 
            clsstaff staff = new clsstaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class i want to create
            clsstaff staff = new clsstaff();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; //this should trigger an error
            //invoke the method
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            //test to see that th reult is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMin()
        {
            clsstaff staff = new clsstaff();
            String Error = "";
            string FirstName = "e";
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            clsstaff staff = new clsstaff();
            String Error = "";
            string FirstName = "ee";
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            clsstaff staff = new clsstaff();
            String Error = "";
            string FirstName = "eeeee";
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMax()
        {
            clsstaff staff = new clsstaff();
            String Error = "";
            string FirstName = "eeeeee";
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMid()
        {
            clsstaff staff = new clsstaff();
            String Error = "";
            string FirstName = "eee";
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            clsstaff staff = new clsstaff();
            String Error = "";
            string FirstName = new string('e', 51);
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameExtremeMax()
        {
            clsstaff staff = new clsstaff();
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'e');
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBExtremeMin()
        {
            clsstaff staff = new clsstaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-101); // 101 years in the past
            string DOB = TestDate.ToString("yyyy-MM-dd");
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DOBMin()
        {
            clsstaff staff = new clsstaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DOB = TestDate.ToString();
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DOBMinPlusOne()
        {
            clsstaff staff = new clsstaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DOB = TestDate.ToString();
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DOBExtremeMax()
        {
            clsstaff staff = new clsstaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DOB = TestDate.ToString();
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DOBInvalidData()
        {
            clsstaff staff = new clsstaff();
            String Error = "";
            string DOB = "this is not a date!";
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        //////
        [TestMethod]
        public void JODExtremeMin()
        {
            clsstaff staff = new clsstaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string JOD = TestDate.ToString();
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void JODMinLessOne()
        {
            clsstaff staff = new clsstaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string JOD = TestDate.ToString();
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void JODMin()
        {
            clsstaff staff = new clsstaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string JOD = TestDate.ToString();
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void JODMinPlusOne()
        {
            clsstaff staff = new clsstaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string JOD = TestDate.ToString();
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void JODExtremeMax()
        {
            clsstaff staff = new clsstaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string JOD = TestDate.ToString();
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void JODInvalidData()
        {
            clsstaff staff = new clsstaff();
            String Error = "";
            string JOD = "this is not a date!";
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        /// </summary>
        /////////////////
        [TestMethod]
        public void LastNameMinLessOne()
        {
            clsstaff staff = new clsstaff();
            String Error = "";
            string LastName = ""; //this should trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMin()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string LastName = "a"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string LastName = "aa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string LastName = "aaaaa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string LastName = "aaaaaa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMid()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string LastName = "aaa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string LastName = new string('a', 51); // This should trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string LastName = new string('a', 500); // This should trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        ////////////
        [TestMethod]
        public void PhonenoMinLessOne()
        {
            clsstaff staff = new clsstaff();
            String Error = "";
            string Phoneno = ""; //this should trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhonenoMin()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string Phoneno = "a"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhonenoMinPlusOne()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string Phoneno = "aa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhonenoMaxLessOne()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string Phoneno = "aaaaa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhonenoMax()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string Phoneno = "aaaaaa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhonenoMid()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string Phoneno = "aaa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhonenoMaxPlusOne()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string Phoneno = "aaaaaaaa999999"; // This should trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhonenoExtremeMax()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string Phoneno = new string('a', 500); // This should trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        ///////
        ///
        [TestMethod]
        public void EmailIdMinLessOne()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string EmailId = ""; // Empty email address
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "emailId may not be blank ;");
        }

        [TestMethod]
        public void EmailIdMin()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string EmailId = "a"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailIdMinPlusOne()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string EmailId = "aa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailIdMaxLessOne()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string EmailId = "aaaaa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailIdMax()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string EmailId = "aaaaaa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailIdMid()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string EmailId = "aaa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailIdMaxPlusOne()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            //Create an email address longer than 50 characters
            string EmailId = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }


        ////////
        ///
        [TestMethod]
        public void PositionMinLessOne()
        {
            clsstaff staff = new clsstaff();
            String Error = "";
            string Position = ""; //this should trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PositionMin()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string Position = "a"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMinPlusOne()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string Position = "aa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMaxLessOne()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string Position = "aaaaa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMax()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string Position = "aaaaaa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PositionMid()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string Position = "aaa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PositionMaxPlusOne()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string Position = new string('a', 51); // This should trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PositionExtremeMax()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string Position = new string('a', 500); // This should trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        ///////////
        ///
        [TestMethod]
        public void SalaryMinLessOne()
        {
            clsstaff staff = new clsstaff();
            String Error = "";
            string Salary = ""; //this should trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SalaryMin()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string Salary = "a"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMinPlusOne()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string Salary = "aa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMaxLessOne()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string Salary = "aaaaa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMax()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string Salary = "aaaaaa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SalaryMid()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string Salary = "aaa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SalaryMaxPlusOne()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string Salary = new string('a', 51); // This should trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryExtremeMax()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string Salary = new string('a', 500); // This should trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        ///////
        ///
        [TestMethod]
        public void FullAddressMinLessOne()
        {
            clsstaff staff = new clsstaff();
            String Error = "";
            string FullAddress = ""; //this should trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FullAddressMin()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string FullAddress = "a"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullAddressMinPlusOne()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string FullAddress = "aa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullAddressMaxLessOne()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string FullAddress = "aaaaa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullAddressMax()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string FullAddress = "aaaaaa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullAddressMid()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string FullAddress = "aaa"; // This should not trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullAddressMaxPlusOne()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string FullAddress = new string('a', 51); // This should trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullAddressExtremeMax()
        {
            clsstaff staff = new clsstaff();
            string Error = "";
            string FullAddress = new string('a', 500); // This should trigger an error
            Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, FullAddress);
            Assert.AreNotEqual(Error, "");
        }


    }
}