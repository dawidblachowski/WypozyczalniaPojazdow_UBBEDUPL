
namespace Wypoz_ASP.Models.Database
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string? RegistrationNumber { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public string Description { get; set; }
        public byte[]? Image { get; set; }

        public VehicleType VehicleType { get; set; }

        public RentalPoint RentalPoint { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}