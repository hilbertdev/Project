
using Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentation.Base;
using Project.Domain.Models;

namespace Presentation.Controllers
{

    public class EventsController : BaseController
    {
        private readonly IRequestHandler<GetEventQuery, Event> _getEventQueryHandler;
        public EventsController(IRequestHandler<GetEventQuery, Event> getEventQueryHandler)
        {
            _getEventQueryHandler = getEventQueryHandler;
        }

        [HttpGet]
        [Route("GetEventById")]
        public IActionResult GetEvents([FromQuery] GetEventQuery query) 
        {
            var result = _getEventQueryHandler.Handle(query, new CancellationToken());
            return Ok(result);
        }

        [HttpGet]
        [Route("GetAllEvents")]
        public IActionResult GetAllEvents()
        {
            return Ok();
        }
    }
}
