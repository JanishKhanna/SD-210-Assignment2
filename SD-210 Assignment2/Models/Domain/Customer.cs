using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SD_210_Assignment2.Models.Domain
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public virtual List<Reservations> Reservations { get; set; }
        public int ReservationId { get; set; }
    }
}