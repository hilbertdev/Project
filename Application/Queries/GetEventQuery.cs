using MediatR;
using Project.Domain.Models;

namespace Application.Queries
{
    public class GetEventQuery : IRequest<Event>
    {
        public int EventId { get; set; }
    }
}
