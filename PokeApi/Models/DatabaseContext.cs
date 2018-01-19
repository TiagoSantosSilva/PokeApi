using System;
using Microsoft.EntityFrameworkCore;

namespace PokeApi.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Status> Status { get; set; }

        public void InitializeDatabase() 
        {
            this.Status.Add(new Status { Code = 200, Description = "API is up." });
            this.Status.Add(new Status { Code = 500, Description = "API is down." });
            this.SaveChanges();
        }
    }
}
