using Project.Domain.Enums;
using Project.Domain.Primitives;

namespace Project.Domain.Models
{
    public class Event : Entity
    {
        internal Event(
            Guid id, 
            string eventName, 
            EventType eventType, 
            string eventLocation, 
            string eventDescription, 
            string eventOrganizerEmail, 
            ICollection<Organizer> organizers, 
            string eventOrganizerContact)
            : base(id)
        {
            EventName = eventName;
            EventType = eventType;
            EventDate = DateTime.Now;
            EventLocation = eventLocation;
            EventDescription = eventDescription;
            EventOrganizerEmail = eventOrganizerEmail;
            Organizers = organizers;
            EventOrganizerContact = eventOrganizerContact;
        }
        public string? EventName { get; set; }
        public EventType EventType { get; set; }
        public DateTime EventDate { get; set; }
        public string? EventLocation { get; set; }
        public string? EventDescription { get; set; }
        public string? EventOrganizerEmail { get; set; }
        public ICollection<Organizer>? Organizers { get; set; }
        public string? EventOrganizerContact { get; set; }

    }
}
