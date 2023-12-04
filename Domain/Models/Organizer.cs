using Project.Domain.Enums;
using Project.Domain.Primitives;

namespace Project.Domain.Models
{
    public sealed class Organizer : Entity
    {
        private readonly List<Event> _events;
        public string? Name { get; set; }
        public ICollection<Event>? Events { get; set; }

        public Organizer(Guid id) : base(id)
        {
            _events = new List<Event>();
        }

        public void CreateEvent(
            Guid id, 
            string eventName,
            EventType eventType, 
            string eventLocation, 
            string eventDescription, 
            string eventOrganizerEmail, 
            ICollection<Organizer> organizers, 
            string eventOrganizerContact)
        {
            var newEvent = new Event(id, eventName, eventType, eventLocation, eventDescription, eventOrganizerEmail, organizers, eventOrganizerContact);
            _events.Add(newEvent);
        }
    }
}
