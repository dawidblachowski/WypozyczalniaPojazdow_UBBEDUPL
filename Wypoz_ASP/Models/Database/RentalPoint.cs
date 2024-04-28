
namespace Wypoz_ASP.Models.Database
{
    public class RentalPoint
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Description { get; set; } = null!;

        public string? AddressStreet { get; set; }
        public string AddressHouseNumber { get; set; }
        public string? AddressFlatNumber { get; set; }
        public string AddressPostalCode { get; set; }
        public string AddressCity { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

    }
}