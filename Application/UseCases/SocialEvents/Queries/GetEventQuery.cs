namespace Application.UseCases.SocialEvents.Queries;
using MediatR;
using Project.Domain.Models;

public class GetEventQuery : IRequest<SocialEvent>
{
    public int EventId { get; set; }
}
