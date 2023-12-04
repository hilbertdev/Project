using Project.Domain.Models;

namespace Domain.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string? TicketName { get; set; }
        public Event? Event { get; set; }
    }
}
