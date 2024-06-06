using System;

namespace ClassLibrary
{
    public class clsOrdIN
    {
        public bool Reserve { get; set; }
        public DateTime Ordtime { get; set; }
        public int Ord_id { get; set; }
        public int CustID { get; set; }
        public int Total_amt { get; set; }
        public string Custname { get; set; }
        public int TblNO { get; set; }
    }
}