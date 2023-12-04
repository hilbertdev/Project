using Project.Domain.Enums;

namespace Project.Domain.Models
{
    public class Event
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
        {
            Id = id;
            EventName = eventName;
            EventType = eventType;
            EventDate = DateTime.Now;
            EventLocation = eventLocation;
            EventDescription = eventDescription;
            EventOrganizerEmail = eventOrganizerEmail;
            Organizers = organizers;
            EventOrganizerContact = eventOrganizerContact;
        }
        
        public Guid Id { get; set; }
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
