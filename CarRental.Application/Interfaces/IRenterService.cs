using CarRental.Application.ViewModels;
using System.Collections.Generic;

namespace CarRental.Application.Interfaces
{
    interface IRenterService
    {
        IEnumerable<RenterWithPassportDataViewModel> GetAllRentersWithPassportData();
    }
}
