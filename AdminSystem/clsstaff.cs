using System;

namespace ClassLibrary
{
    public class clsstaff
    {
        public DateTime joiningDate;

        public bool Gender { get; set; }
        public int StaffId { get; set; }
        public string EmailId { get; set; }
        public string Fulladdress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int Phoneno { get; set; }
        public DateTime DOB { get; set; }
        public decimal Salary { get; set; }
    }
}