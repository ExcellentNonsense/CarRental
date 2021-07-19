using CarRental.Domain.Entities;
using System.Collections.Generic;

namespace CarRental.Domain.Interfaces.Repositories
{
    public interface ILocationRepo : IRepository<Location>
    {
        IEnumerable<Location> GetAllWithFullData();
    }
}
