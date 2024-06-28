using BotanikBambu.Data;
using BotanikBambu.Models;
using Microsoft.EntityFrameworkCore;

namespace BotanikBambu.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       public virtual DbSet<Orderİnfo> Orderİnfos { get; set; }
        public virtual DbSet<Truckerİnfo> Truckerİnfos { get; set; }
        public virtual DbSet<Customerİnfo> Customerİnfos { get; set; }
        public virtual DbSet<Cushionİnfo> Cushionİnfos { get; set; }

        // Add other DbSet properties as needed
    }
}
