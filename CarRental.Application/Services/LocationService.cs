using CarRental.Application.Interfaces;
using CarRental.Application.ViewModels;
using CarRental.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace CarRental.Application.Services
{
    public class LocationService : ILocationService
    {
        private readonly IRepoUnitOfWork _repos;

        public LocationService(IRepoUnitOfWork repoUnitOfWork)
        {
            _repos = repoUnitOfWork;
        }

        public IEnumerable<LocationViewModel> GetAllLocations()
        {
            return _repos.Locations.GetAllWithFullData()
                .Select(x => LocationViewModel.CreateFromLocation(x))
                .ToList();
        }
    }
}
