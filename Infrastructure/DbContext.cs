using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Project.Domain.Models;

namespace Project.Infrastructure
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {

        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        

        // Define your entity DbSet properties here

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entity mappings here
        }
    }
}
