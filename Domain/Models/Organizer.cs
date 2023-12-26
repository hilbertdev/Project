namespace Project.Domain.Models;
using Project.Domain.Enums;
using Project.Domain.Primitives;
using Project.Domain.Primitives.ValueObjects;

public sealed class Organizer(Guid id) : Entity(id)
{
    private readonly List<SocialEvent> events = [];
    public string? Name { get; set; }
    public ICollection<SocialEvent>? Events { get; set; }

    public void CreateEvent(
        Guid id,
        string eventName,
        EventType eventType,
        Guid venueId,
        string eventDescription,
        Email eventOrganizerEmail,
        string eventOrganizerContact)
    {
        var newEvent = new SocialEvent(id, eventName, eventType, venueId, eventDescription, eventOrganizerEmail, eventOrganizerContact);
        this.events.Add(newEvent);
    }
    public ICollection<SocialEvent> GetEvents() => this.events;
}
