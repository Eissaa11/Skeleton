using System;

namespace ClassLibrary
{
    public class clsReservation
    {
        public bool Active { get; set; }
        public bool Age { get; set; }
        public DateTime DateAndTime { get; set; }
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public object Phone { get; set; }
        public int TableNumber { get; set; }
    }
}