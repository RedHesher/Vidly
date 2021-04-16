using DocumentFormat.OpenXml.ExtendedProperties;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace Vidly.Models
{
    public class ApplicationUser : IdentityUser
    {
        //public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser>)
        //{
        //    var userIdentity = await manager.CrateIdentityAsync(this, DefaultAuthenticationTypes);

        //    return userIdentity;
        //}

        public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Movie> Movies { get; set; }
            public DbSet<MembershipType> MembershipTypes { get; set; }

            public ApplicationDbContext() 
                : base ("DefaultConnection", throwIfV1Schema: false)
            { 
            }

            public static ApplicationDbContext Create()
            {
                return new ApplicationDbContext();
            }
        }
    }
}