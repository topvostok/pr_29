using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PG_29.Common;
using PG_29.Models;

namespace PG_29.Classes
{
    class UserContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public UserContext() =>
            Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
    optionsBuilder.UseMySql(Config.ConnectionConfig, Config.Version);
    }
}
