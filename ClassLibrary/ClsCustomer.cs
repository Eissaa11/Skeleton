﻿using System;

namespace ClassLibrary
{
    public class ClsCustomer
    {
        public ClsCustomer()
        {
        }

        public bool GenderPropertryOK { get; set; }
        public bool Gender { get; set; }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
     
        public int phoneno { get; set; }
        public string Address { get; set; }
       
       
        public DateTime Orderdate { get; set; }

        public bool find(int customerId)
        {
            // always return true
            return true;
            throw new NotImplementedException();
        }
    }
}