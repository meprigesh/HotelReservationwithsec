using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HotelReservationSystem.ApplicationCore.Model;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Infrastructure.Data
{
    public class HotelReservationContext : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Database=HootelReservationDb1;Integrated Security=true");
        }
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookedRoom> BookedRooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
    }
}
    

