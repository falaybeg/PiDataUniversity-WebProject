using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using PiData.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PiData.Domain.Model
{
    public class ApplicationUserr : IdentityUser
    {
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        [Column(TypeName = "DateTime2")]
        public Nullable<DateTime> RegisteredDate { get; set; }

        [Column(TypeName = "DateTime2")]
        public Nullable<DateTime> BirthDay { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUserr> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }

        public virtual ICollection<Student> Student { get; set; }
        public virtual ICollection<Teacher> Teacher { get; set; }

    }
}
