using CarRental.Domain.Entities;
using System;

namespace CarRental.Application.ViewModels
{
    public class RenterWithPassportDataViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PassportNumber { get; set; }

        public static RenterWithPassportDataViewModel CreateFromRenter (Renter renter)
        {
            return new RenterWithPassportDataViewModel
            {
                FirstName = renter.FirstName,
                LastName = renter.LastName,
                FullName = renter.FullName,
                BirthDate = renter.Passport.BirthDate,
                Email = renter.Email,
                PhoneNumber = renter.PhoneNumber,
                PassportNumber = renter.Passport.Number
            };
        }
    }
}
