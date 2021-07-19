using CarRental.Domain.Entities;
using System.Collections.Generic;

namespace CarRental.Domain.Interfaces.Repositories
{
    public interface IRenterRepo : IRepository<Renter>
    {
        IEnumerable<Renter> GetAllWithPassportData();
    }
}
