using CarRental.Application.ViewModels;
using System.Collections.Generic;

namespace CarRental.Application.Interfaces
{
    interface ILocationService
    {
        IEnumerable<LocationViewModel> GetAllLocations();
    }
}
