namespace Application.UseCases.SocialEvents.Queries;
using Application.Repositories;
using MediatR;
using Project.Domain.Models;

public class GetEventQueryHandler(IEventRepository eventRepository) : IRequestHandler<GetEventQuery, SocialEvent>
{
    private readonly IEventRepository eventRepository = eventRepository;

    public async Task<SocialEvent> Handle(GetEventQuery request, CancellationToken cancellationToken)
    {
        var eventId = request.EventId;
        var eventName = await this.eventRepository.GetEventById(eventId);
        return eventName;
    }
}