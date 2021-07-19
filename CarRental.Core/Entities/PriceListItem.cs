using System.Collections.Generic;

namespace CarRental.Domain.Entities
{
    public class PriceListItem : BaseEntity
    {
        public Car Car { get; set; }
        public decimal PricePerDay { get; set; }

        public int CarId { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
