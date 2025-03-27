using Microsoft.EntityFrameworkCore;

namespace MM.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet dla tabel w bazie danych
        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
