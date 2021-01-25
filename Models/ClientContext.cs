using Microsoft.EntityFrameworkCore;

namespace TeleHealth_API.Models
{
    /*
        Client Context Class

        Description: This class extends the Db context interface and allows the API
                     to store data that is being submitted to the client whilst it remains active.
    */
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options)
            : base(options)
        {
        }

        public DbSet<Client> ClientItems { get; set; }
    }
}