namespace Project.Domain.Models;

using Project.Domain.Primitives;

public class EventOrganizer : Entity
{
    public Guid EventId { get; set; }
    public SocialEvent? Event { get; set; }
    public Guid OrganizerId { get; set; }
    public Organizer? Organizer { get; set; }
}

