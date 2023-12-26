using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Models;

namespace Project.Infrastructure
{
    public class AutoTicketContext : DbContext
    {

        public AutoTicketContext(DbContextOptions<AutoTicketContext> options) : base(options)
        {
        }

        public DbSet<SocialEvent> Events { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        

        // Define your entity DbSet properties here

        public void Configure(EntityTypeBuilder<SocialEvent> builder)
        {
            builder.Property(e => e.EventName).HasMaxLength(50).IsRequired();
            builder.Property(e => e.EventType).IsRequired();
            builder.Property(e => e.EventDate).IsRequired();
            builder.Property(e => e.EventLocation).HasMaxLength(50).IsRequired();
            builder.Property(e => e.EventDescription).HasMaxLength(50).IsRequired();
            builder.OwnsOne(e => e.EventOrganizerEmail);
            builder.Property(e => e.EventOrganizerContact).HasMaxLength(50).IsRequired();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           Configure(modelBuilder.Entity<SocialEvent>());
        }
    }
}
