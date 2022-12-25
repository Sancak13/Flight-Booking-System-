using FlightBookingSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Web;
namespace FlightBookingSystem.Contracts
{
    public class Context : DbContext
    {
        public Context() : base()
        {

        }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<BookingFlights> bookings { get; set; }
        public DbSet<PassengerInfo> passes { get; set; }
        public DbSet<DailyFlights> dailyFlights { get; set; }

    }
}
