using Project.Domain.Enums;
using Project.Domain.Primitives;
using Project.Domain.Primitives.ValueObjects;

namespace Project.Domain.Models
{
    public class Event : Entity
    {
        public Event()
        {
            
        }
        internal Event(
            Guid id, 
            string eventName, 
            EventType eventType, 
            string eventLocation, 
            string eventDescription, 
            Email eventOrganizerEmail,  
            string eventOrganizerContact)
            : base(id)
        {
            EventName = eventName;
            EventType = eventType;
            EventDate = DateTime.Now;
            EventLocation = eventLocation;
            EventDescription = eventDescription;
            EventOrganizerContact = eventOrganizerContact;
            EventOrganizerEmail = eventOrganizerEmail;
        }
        public string? EventName { get; set; }
        public EventType EventType { get; set; }
        public DateTime EventDate { get; set; }
        public string? EventLocation { get; set; }
        public string? EventDescription { get; set; }
        public Email EventOrganizerEmail { get; set; }
        public string? EventOrganizerContact { get; set; }

    }
}
