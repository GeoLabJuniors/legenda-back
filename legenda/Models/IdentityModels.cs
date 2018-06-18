using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace legenda.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public partial class ApplicationUser : IdentityUser
    {
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
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Brochure> Brochures { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<InitialUser> InitialUsers { get; set; }
        public DbSet<InitialUsersToSeasons> InitialUsersToSeasons { get; set; }
        public DbSet<JuriesToSeasons> JuriesToSeasons { get; set; }
        public DbSet<Jury> Juries { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<SeasonsToImages> SeasonsToImages { get; set; }
        public DbSet<User> FinalUsers { get; set; }
        public DbSet<Work> Works { get; set; }


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}