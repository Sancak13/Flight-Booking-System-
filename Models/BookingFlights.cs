namespace FlightBookingSystem.Models
{
    public class BookingFlights
    {
        public string Origin { get; set; }
        public string OriginAirport { get; set; }
        public string Destination { get; set; }
        public string DestinationAirport { get; set; }
        public DateTime FlightDate { get; set; }
        public string FlightNO { get; set; }
    }
}
