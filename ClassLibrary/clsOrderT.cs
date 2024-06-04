using System;

namespace ClassLibrary
{
    public class clsOrderT
    {
        public clsOrderT()
        {
        }

        public bool Active { get; set; }
        public int Order_Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateAdded { get; set; }
        public string Firstname { get; set; }
        public int Total_amount { get; set; }
        public int phoneno { get; set; }
    }
}