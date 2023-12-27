namespace Project.Domain.Models;

using Project.Domain.Primitives;

public class Ticket(Guid id) : Entity(id)
{
    public string? TicketName { get; set; }
    public SocialEvent? Event { get; set; }
}
