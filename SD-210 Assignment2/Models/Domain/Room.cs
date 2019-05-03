using SD_210_Assignment2.Models.MyHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SD_210_Assignment2.Models.Domain
{
    public class Room
    {
        public int Id { get; set; } 
        public RoomNumber RoomNumber { get; set; }
        public RoomType RoomType { get; set; }
        public DailyRate DailyRate { get; set; }
        public List<Reservations> Reservations { get; set; }
    }
}