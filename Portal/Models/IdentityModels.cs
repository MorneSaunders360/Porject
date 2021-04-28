using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Threading.Tasks;


namespace Portal.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType

            var userIdentity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);

            userIdentity.AddClaim(new Claim(ClaimTypes.Name, this.UserName));
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext
    {
        //string connectionName = System.Configuration.ConfigurationManager.AppSettings["DatabaseConnectionName"];
        //string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<IdentityUser> IdentityUser { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

    }
}