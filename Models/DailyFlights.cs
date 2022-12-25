namespace FlightBookingSystem.Models
{
    public class DailyFlights
    {
        public string Airline { get; set; }
        public string OriginAirport { get; set; }
        public string DestinationAirport { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string FlightNO { get; set; }
    }
}
