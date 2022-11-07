using Assignment4.Models.PaymentOptions.Services;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Country { get; set; }

        public string BankName { get; set; }

        public string BankAccountNumber { get; set; }
        public decimal? Payment { get; set; }

        [CreditCard(ErrorMessage = "Please use a valid credit card")]
        public string Card { get; set; }

        public DateTime CardExpDate { get; set; }

        public short CardThreeDigitNumber { get; set; }

        public string CardFirstName { get; set; }
        public string CardLastName { get; set; }
        public string CardType { get; internal set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Tshirt> Tshirts { get; set; }

        public DbSet<Color> Colors { get; set; }
        public DbSet<Fabric> Fabrics { get; set; }
        public DbSet<Size> Sizes { get; set; }

        public DbSet<Orders> Orders { get; set; }

        public DbSet<Order> Order { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}