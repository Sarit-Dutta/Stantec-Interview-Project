using Microsoft.EntityFrameworkCore;

namespace TeleHealth_API.Models
{
    /*
        User Context

        Description: User Context extends the db context and allows the API to store data
                     in relation to this model so long as the API remains active.
    */
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}