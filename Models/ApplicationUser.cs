using Microsoft.EntityFrameworkCore;

namespace RegisterForm_InCore.Models
{
    public class ApplicationUser:DbContext
    {
        public ApplicationUser(DbContextOptions<ApplicationUser> options) : base(options)
        {

        }
        public DbSet<User> UserRegistration { get; set; }
    }
}
