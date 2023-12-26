namespace Presentation.Controllers;

using Application.UseCases.SocialEvents.Commands;
using Application.UseCases.SocialEvents.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentation.Base;
using Project.Domain.Models;

public class EventsController(IRequestHandler<GetEventQuery, SocialEvent> getEventQueryHandler,
IRequestHandler<CreateEventCommand> createEventCommandHandler) : BaseController
{
    private readonly IRequestHandler<GetEventQuery, SocialEvent> getEventQueryHandler = getEventQueryHandler;
    private readonly IRequestHandler<CreateEventCommand> createEventCommandHandler;

    [HttpGet]
    [Route("GetEventById")]
    public IActionResult GetEvents([FromQuery] GetEventQuery query)
    {
        var result = this.getEventQueryHandler.Handle(query, new CancellationToken());
        return this.Ok(result);
    }

    [HttpGet]
    [Route("GetAllEvents")]
    public IActionResult GetAllEvents() => this.Ok();

    [HttpPost]
    [Route("CreateEvent")]
    public IActionResult CreateEvent([FromBody] CreateEventCommand command)
    {
        var result = this.createEventCommandHandler.Handle(command, new CancellationToken());
        return this.Ok(result);
    }
}
