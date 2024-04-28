namespace Wypoz_ASP.Models.Database
{
    public class VehicleType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}