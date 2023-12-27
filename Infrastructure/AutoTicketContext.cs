namespace Project.Infrastructure;

using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
public class AutoTicketContext(DbContextOptions<AutoTicketContext> options) : DbContext(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
{
    public DbSet<SocialEvent> Events { get; set; }
    public DbSet<Organizer> Organizers { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Venue> Venues { get; set; }

    public static void Configure(ModelBuilder builder) => ConfigureSocialEvent(builder.Entity<SocialEvent>());

    private static void ConfigureSocialEvent(EntityTypeBuilder<SocialEvent> builder)
    {
        builder.Property(e => e.EventName).HasMaxLength(50).IsRequired();
        builder.Property(e => e.EventType).IsRequired();
        builder.Property(e => e.EventDate).IsRequired();
        builder.Property(e => e.VenueiD).IsRequired();
        builder.Property(e => e.EventDescription).HasMaxLength(50).IsRequired();
        builder.OwnsOne(e => e.EventOrganizerEmail);
        builder.Property(e => e.EventOrganizerContact).HasMaxLength(50).IsRequired();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) => Configure(modelBuilder);
}
