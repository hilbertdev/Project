namespace Project.Domain.Models;
using Project.Domain.Enums;
using Project.Domain.Primitives;
using Project.Domain.Primitives.ValueObjects;

public class SocialEvent : Entity
{
    public SocialEvent()
    {

    }
    internal SocialEvent(
        Guid id,
        string eventName,
        EventType eventType,
        Guid? venueId,
        string eventDescription,
        Email eventOrganizerEmail,
        string eventOrganizerContact)
        : base(id)
    {
        this.EventName = eventName;
        this.EventType = eventType;
        this.EventDate = DateTime.Now;
        this.VenueiD = venueId;
        this.EventDescription = eventDescription;
        this.EventOrganizerContact = eventOrganizerContact;
        this.EventOrganizerEmail = eventOrganizerEmail;
    }
    public string? EventName { get; set; }
    public EventType EventType { get; set; }
    public DateTime EventDate { get; set; }
    public Guid? VenueiD { get; set; }
    public string? EventDescription { get; set; }
    public Email EventOrganizerEmail { get; set; }
    public string? EventOrganizerContact { get; set; }

}
