using Microsoft.EntityFrameworkCore;
using PG_29.Common;
using PG_29.Models;

namespace WpfApp1.Classes
{
    public class ClubsContext : DbContext  
    {
        public DbSet<Clubs> Clubs { get; set; }

        public ClubsContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(Config.ConnectionConfig, Config.Version);
            }
        }
        public void EnsureDatabaseCreated()
        {
            Database.EnsureCreated();
        }
    }
}