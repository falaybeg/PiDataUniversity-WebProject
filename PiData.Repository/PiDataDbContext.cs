using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using PiData.Domain;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;


namespace PiDataApp.Repository
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
    public class PiDataDbContext : IdentityDbContext<ApplicationUser>
    {

        public PiDataDbContext()
                : base("PiDataDbContext")
        {
        }

        public virtual DbSet<Category> Category { get; set; }



    }
}
