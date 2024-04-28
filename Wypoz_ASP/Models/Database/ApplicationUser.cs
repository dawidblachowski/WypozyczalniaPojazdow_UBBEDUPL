using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wypoz_ASP.Models.Database
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public string? AddressStreet { get; set; }
        public string AddressHouseNumber { get; set; }
        public string? AddressFlatNumber { get; set; }
        public string AddressPostalCode { get; set; }
        public string AddressCity { get; set; }
    }
}
