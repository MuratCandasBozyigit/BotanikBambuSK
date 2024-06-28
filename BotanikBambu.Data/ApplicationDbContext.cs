using Microsoft.EntityFrameworkCore;

namespace BotanikBambu.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

     

        // DbSet'lerinizi buraya ekleyin
        // public DbSet<YourEntity> YourEntities { get; set; }
    }
}
