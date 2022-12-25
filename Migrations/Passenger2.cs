using Microsoft.EntityFrameworkCore;

namespace FlightBookingSystem.Migrations
{
    public partial class Passenger2
    {
        protected override void model(ModelBuilder modelBuilder)
        {
            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1, 1);

            modelBuilder.Entity("FlightBookingSystem.Models.PassengerInfo", x =>
            {
                x.Property<string>("Firstname").HasColumnType("nvarchar(max)");
                x.Property<string>("Lastname").HasColumnType("nvarchar(max)");
                x.Property<DateTime>("DateOfBirth").HasColumnType("datetime2");
                x.Property<DateTime>("DateOfFlight").HasColumnType("datetime2");
                x.Property<string>("PhoneNumber").HasColumnType("nvarchar(max)");
                x.Property<string>("Email").HasColumnType("nvarchar(max)");
                x.Property<string>("PassportNO").HasColumnType("nvarchar(max)");
                x.Property<string>("        public string Nationality { get; set; }\r\n").HasColumnType("nvarchar(max)");
            });

        }
    }
}
