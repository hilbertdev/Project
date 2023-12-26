namespace Application.UseCases.SocialEvents.Commands;
using MediatR;
using Project.Domain.Enums;
using Project.Domain.Primitives.ValueObjects;

public class CreateEventCommand : IRequest
{
    public Guid Id { get; set; }
    public string? EventName { get; set; }
    public EventType EventType { get; set; }
    public Guid? VenueId { get; set; }
    public string? EventDescription { get; set; }
    public Email? EventOrganizerEmail { get; set; }
    public string? EventOrganizerContact { get; set; }
    public Guid? OrganizerId { get; set; }
}
