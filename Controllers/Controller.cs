
using FlightBookingSystem.Contracts;
using FlightBookingSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace FlightBookingSystem.Controllers
{
    public class Controller : Context
    {
        private readonly FlightBookingSystem bookingSystem;
        public FlightBookingSystem(FlightBookingSystem dbcontext) => bookingSystem = dbcontext;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookingFlights>>> get()
        {
            if (bookingSystem == null)
                return NotFoundResult();
            return await bookingSystem.get();
        }
        [HttpPost]
        public async Task<AcceptedResult<BookingFlights>>(plane)
            {
            BookingFlights.add(plane)
            await BookingFlights.SaveChangesAsync();
            return OkResult("Added");
            }
    }
}
