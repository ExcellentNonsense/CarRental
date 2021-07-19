using System;

namespace CarRental.Domain.Entities
{
    public class RenterPassport : BaseEntity
    {
        public string Number { get; set; }
        public DateTime BirthDate { get; set; }

        public Renter Renter { get; set; }
    }
}
