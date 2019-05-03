namespace SD_210_Assignment2.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using SD_210_Assignment2.Models;
    using SD_210_Assignment2.Models.Domain;
    using SD_210_Assignment2.Models.MyHelpers;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SD_210_Assignment2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SD_210_Assignment2.Models.ApplicationDbContext context)
        {

            var customers = new List<Customer>
            {
                new Customer { FirstName = "Alan",
                    LastName = "Foster",
                    Email = "alanfoster@assignment2.com",
                    PhoneNumber = "(204) – 111-1111"
                },
                new Customer { FirstName = "Harley",
                    LastName = "Moore",
                    Email = "harleymoore@assignment2.com",
                    PhoneNumber = "(204) – 222-2222"
                },
                new Customer { FirstName = "Kara",
                    LastName = "Rogers",
                    Email = "kararogers@assignment2.com",
                    PhoneNumber = "(204) – 333-3333"
                },
                new Customer { FirstName = "Lara",
                    LastName = "Mason",
                    Email = "laramason@assignment2.com",
                    PhoneNumber = "(204) – 444-4444"
                },
                 new Customer { FirstName = "Amber",
                    LastName = "Hunt",
                    Email = "amberhunt@assignment2.com",
                    PhoneNumber = "(204) – 555-5555"
                },
            };

            customers.ForEach(p => context.Customers.AddOrUpdate(guest => guest.FirstName, p));
            context.SaveChanges();

            var rooms = new List<Room>
            {
                new Room
                {
                    RoomNumber = RoomNumber.OneA,
                    RoomType = RoomType.Single,
                    DailyRate = '$'+DailyRate.a
                },
                new Room
                {
                    RoomNumber = RoomNumber.OneB,
                    RoomType = RoomType.Single,
                    DailyRate = '$'+DailyRate.a
                },
                new Room
                {
                    RoomNumber = RoomNumber.TwoA,
                    RoomType = RoomType.Double,
                    DailyRate = '$'+DailyRate.b
                },
                new Room
                {
                    RoomNumber = RoomNumber.TwoB,
                    RoomType = RoomType.Double,
                    DailyRate = '$'+DailyRate.b
                },
                new Room
                {
                    RoomNumber = RoomNumber.ThreeA,
                    RoomType = RoomType.Queen,
                    DailyRate = '$'+DailyRate.c
                },
                new Room
                {
                    RoomNumber = RoomNumber.ThreeB,
                    RoomType = RoomType.Queen,
                    DailyRate = '$'+DailyRate.c
                },
                new Room
                {
                    RoomNumber = RoomNumber.ThreeC,
                    RoomType = RoomType.Queen,
                    DailyRate = '$'+DailyRate.c
                },
                new Room
                {
                    RoomNumber = RoomNumber.FourA,
                    RoomType = RoomType.King,
                    DailyRate = '$'+DailyRate.d
                },
                new Room
                {
                    RoomNumber = RoomNumber.FourB,
                    RoomType = RoomType.King,
                    DailyRate = '$'+DailyRate.d
                },
                new Room
                {
                    RoomNumber = RoomNumber.FiveA,
                    RoomType = RoomType.MasterSuite,
                    DailyRate = '$'+DailyRate.e
                },

            };

            rooms.ForEach(p => context.Rooms.AddOrUpdate(room => room.Id, p));
            context.SaveChanges();

            
            

            var reservations = new List<Reservations>
            {
                new Reservations
                {
                    ReservationCode = "PMJYW5WH2",
                    CheckIn = "April 8, 2019",
                    CheckOut = "April 12, 2019",
                    TotalAmount = '$'+"250",
                    Customer = customers.FirstOrDefault(p=> p.FirstName == "Alan"),
                    Room = rooms.FirstOrDefault(p => p.RoomNumber == RoomNumber.OneA)
                },
                new Reservations
                {
                    ReservationCode = "Y1SNW2YQ3",
                    CheckIn = "April 15, 2019",
                    CheckOut = "April 19, 2019",
                    TotalAmount = '$'+"250",
                    Customer = customers.FirstOrDefault(p=> p.FirstName == "Harley"),
                    Room = rooms.FirstOrDefault(p => p.RoomNumber == RoomNumber.OneB)
                   
                },
                new Reservations
                {
                    ReservationCode = "ICKU0JMMN",
                    CheckIn = "April 22, 2019",
                    CheckOut = "April 24, 2019",
                    TotalAmount = '$'+"150",
                    Customer = customers.FirstOrDefault(p=> p.FirstName == "Alan"),
                    Room = rooms.FirstOrDefault(p => p.RoomNumber == RoomNumber.OneA)
                },
                new Reservations
                {
                    ReservationCode = "EW4X1NWEU",
                    CheckIn = "May 1, 2019",
                    CheckOut = "May 10, 2019",
                    TotalAmount = '$'+"1300",
                    Customer = customers.FirstOrDefault(p=> p.FirstName == "Kara"),
                    Room = rooms.FirstOrDefault(p => p.RoomNumber == RoomNumber.ThreeA)
                },
                new Reservations
                {
                    ReservationCode = "7XLLBVZYB",
                    CheckIn = "May 6, 2019",
                    CheckOut = "May 10, 2019",
                    TotalAmount = '$'+"1000",
                    Customer = customers.FirstOrDefault(p=> p.FirstName == "Amber"),
                    Room = rooms.FirstOrDefault(p => p.RoomNumber == RoomNumber.FourB)
                },
                new Reservations
                {
                    ReservationCode = "WD4EFAINV",
                    CheckIn = "May 13, 2019",
                    CheckOut = "May 17, 2019",
                    TotalAmount = '$'+"1000",
                    Customer = customers.FirstOrDefault(p=> p.FirstName == "Lara"),
                    Room = rooms.FirstOrDefault(p => p.RoomNumber == RoomNumber.FourB)
                },
                new Reservations
                {
                    ReservationCode = "Y4Y97Q4WG",
                    CheckIn = "May 13, 2019",
                    CheckOut = "May 15, 2019",
                    TotalAmount = '$'+"150",
                    Customer = customers.FirstOrDefault(p=> p.FirstName == "Alan"),
                    Room = rooms.FirstOrDefault(p => p.RoomNumber == RoomNumber.OneA)
                },
            };

            reservations.ForEach(p => context.Reservations.AddOrUpdate(z => z.ReservationCode, p));
            context.SaveChanges();

        }



    }
}

