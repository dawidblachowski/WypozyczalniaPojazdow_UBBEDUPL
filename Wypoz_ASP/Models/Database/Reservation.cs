
namespace Wypoz_ASP.Models.Database
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string Status { get; set; } = null!;
        public string Description { get; set; } = null!;

        public Vehicle Vehicle { get; set; }

        public ApplicationUser User { get; set; }
    }
}
