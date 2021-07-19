using System.Collections.Generic;

namespace CarRental.Domain.Entities
{
    public class City : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Location> Locations { get; set; }
    }
}
