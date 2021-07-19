using System.Collections.Generic;

namespace CarRental.Domain.Entities
{
    public class Renter : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public RenterPassport Passport { get; set; }

        public string FullName => (FirstName?.Trim() + " " + LastName?.Trim()).Trim();

        public ICollection<Order> Orders { get; set; }
    }
}
