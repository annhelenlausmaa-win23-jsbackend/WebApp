using Microsoft.AspNetCore.Identity;

namespace WebApp.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Biography { get; set; }
        public string? ProfileImage { get; set; } = "avatar.jpg";
        public int? AddressId { get; set; }
        public AddressEntity? Address { get; set; }
    }

    public class AddressEntity
    {
        public int Id { get; set; }
        public string AddressLine1 { get; set; } = null!;
        public string? AddressLine2 { get; set; }
        public string PostalCode { get; set; } = null!;
        public string City { get; set; } = null!;
    }

}
