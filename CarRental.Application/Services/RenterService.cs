using CarRental.Application.Interfaces;
using CarRental.Application.ViewModels;
using CarRental.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace CarRental.Application.Services
{
    public class RenterService : IRenterService
    {
        private readonly IRepoUnitOfWork _repos;

        public RenterService(IRepoUnitOfWork repoUnitOfWork)
        {
            _repos = repoUnitOfWork;
        }

        public IEnumerable<RenterWithPassportDataViewModel> GetAllRentersWithPassportData()
        {
            return _repos.Renters.GetAllWithPassportData()
                .Select(x => RenterWithPassportDataViewModel.CreateFromRenter(x))
                .ToList();
        }
    }
}
