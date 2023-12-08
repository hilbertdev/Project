
using Project.Domain.Primitives;

namespace Project.Domain.Models
{
    public class EventOrganizer : Entity
    {
        public Guid EventId { get; set; }
        public Event? Event { get; set; }
        public Guid OrganizerId { get; set; }
        public Organizer? Organizer { get; set; }
    }
}
