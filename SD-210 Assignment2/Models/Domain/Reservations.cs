using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SD_210_Assignment2.Models.Domain
{
    public class Reservations
    {
        public int Id { get; set; }
        public string ReservationCode { get; set; }
        public virtual Room Room { get; set; }
        public int RoomId { get; set; }

        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }

        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public string TotalAmount { get; set; }
    }
}