using Application.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;
using Project.Domain.Enums;
using Project.Domain.Models;

namespace Application.Commands
{
    public class CreateEventCommand : IRequest
    {
        public Guid Id { get; set; }
        public string? EventName { get; set; }
        public EventType EventType { get; set; }
        public string? EventLocation { get; set; }
        public string? EventDescription { get; set; }
        public string? EventOrganizer { get; set; }
        public string? EventOrganizerEmail { get; set; }
        public ICollection<Organizer>? Organizers { get; set; }
        public string? EventOrganizerContact { get; set; }
    }

    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand>
    {
        /// <summary>
        /// Represents the event repository used for data access.
        /// </summary>
        private readonly IEventRepository _eventRepository;

        /// <summary>
        /// The mapper used for mapping objects in the CreateEventCommand class.
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// The validator used to validate the <see cref="CreateEventCommand"/> object.
        /// </summary>
        private readonly IValidator<CreateEventCommand> _validator;

        public CreateEventCommandHandler(IEventRepository eventRepository, IMapper mapper, IValidator<CreateEventCommand> validator)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
            _validator = validator;
        }

        public Task<Unit> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            var validationResult = _validator.Validate(request);

            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var newEvent = _mapper.Map<Event>(request);
            _eventRepository.Add(newEvent);
            return Task.FromResult(Unit.Value);
        }
    }
}
