using Microsoft.EntityFrameworkCore;
using BotanikBambu.Models;

namespace BotanikBambu.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Truckerİnfo> Orderİnfos { get; set; }
        public virtual DbSet<Truckerİnfo> Truckerİnfos { get; set; }
        public virtual DbSet<Customerİnfo> Customerİnfos { get; set; }
        public virtual DbSet<Cushionİnfo> Cushionİnfos { get; set; }

        // Add other DbSet properties as needed
    }
}
