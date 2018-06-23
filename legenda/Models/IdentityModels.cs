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

        public DbSet<Image> Images { get; set; }
        public DbSet<ParticipantsToSeasons> UsersToSeasons { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<SeasonsToImages> SeasonsToImages { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<ConfirmRole> ConfirmRoles { get; set; }
        public DbSet<JuriesToSeasons> JuriesToSeasons { get; set; }


        public static ApplicationDbContext Create()
        { 
            
            return new ApplicationDbContext();
        }
    }
}