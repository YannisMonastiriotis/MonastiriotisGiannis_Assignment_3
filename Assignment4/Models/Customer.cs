using System;

namespace Assignment4.Models
{
    public class Customer
    {
        private string Id { get; set; }
        private string FirstName { get; set; }

        private string LastName { get; set; }

        private DateTime BirthDate { get; set; }

        private string Country { get; set; }

        public Customer(ApplicationUser user)
        {
            Id = user.Id;
            FirstName = user.Name;
            LastName = user.LastName;
            BirthDate = user.DateOfBirth;
            Country = user.Country;
        }
    }
}