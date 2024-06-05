using System;

namespace Testing6
{
    internal class clsOrdIN
    {
        public bool Reserve { get; internal set; }
        public DateTime Ordtime { get; internal set; }
        public int Ord_id { get; internal set; }
        public int CustID { get; internal set; }
        public int totalamount { get; internal set; }
        public int TblNO { get; internal set; }
        public string Custname { get; internal set; }
    }
}