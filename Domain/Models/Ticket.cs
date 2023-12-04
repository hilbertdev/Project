using Project.Domain.Models;
using Project.Domain.Primitives;

namespace Domain.Models
{
    public class Ticket : Entity
    {
        public Ticket(Guid id) : base(id)
        {
            
        }
        
        public string? TicketName { get; set; }
        public Event? Event { get; set; }
    }
}
