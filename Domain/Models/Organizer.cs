using Project.Domain.Enums;
using Project.Domain.Primitives;
using Project.Domain.Primitives.ValueObjects;

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
            Email? eventOrganizerEmail, 
            string eventOrganizerContact)
        {
            var newEvent = new Event(id, eventName, eventType, eventLocation, eventDescription, eventOrganizerEmail, eventOrganizerContact);
            _events.Add(newEvent);
        }
         public ICollection<Event> GetEvents()
         {
            return _events;
         }
    }
}
