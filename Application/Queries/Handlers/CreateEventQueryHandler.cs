using Application.Queries;
using Application.Repositories;
using MediatR;
using Project.Domain.Models;

public class GetEventQueryHandler : IRequestHandler<GetEventQuery, Event>
{
    private readonly IEventRepository _eventRepository;

    public GetEventQueryHandler(IEventRepository eventRepository)
    {
        _eventRepository = eventRepository;
    }

    public async Task<Event> Handle(GetEventQuery request, CancellationToken cancellationToken)
    {
        var eventId = request.EventId;
        var eventName = await _eventRepository.GetEventById(eventId);
        return eventName;
    }
}