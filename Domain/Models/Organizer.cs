using Project.Domain.Enums;

namespace Project.Domain.Models
{
    public sealed class Organizer
    {
        private readonly List<Event> _events;
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Event>? Events { get; set; }

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
