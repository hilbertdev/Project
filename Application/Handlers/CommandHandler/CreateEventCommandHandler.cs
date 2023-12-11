using Application.Commands;
using Application.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;
using Project.Domain.Models;

namespace Application.Handlers.CommandHandler
{
    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand>
    {
        /// <summary>
        /// Represents the event repository used for data access.
        /// </summary>
        private readonly IEventRepository _eventRepository;


        /// <summary>
        /// The validator used to validate the <see cref="CreateEventCommand"/> object.
        /// </summary>
        private readonly IValidator<CreateEventCommand> _validator;

        public CreateEventCommandHandler(IEventRepository eventRepository, IValidator<CreateEventCommand> validator)
        {
            _eventRepository = eventRepository;
            _validator = validator;
        }

        public Task<Unit> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            var validationResult = _validator.Validate(request);

            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var organizer = _eventRepository.GetOrganizerById(request.OrganizerId!.Value) ?? throw new ValidationException("Please register as an organizer first.");
           
            organizer.CreateEvent(
                request.Id,
                request.EventName!,
                request.EventType,
                request.EventLocation!,
                request.EventDescription!,
                request.EventOrganizerEmail!,
                request.EventOrganizerContact!);


            _eventRepository.AddAsync(organizer.GetEvents().FirstOrDefault(x => x.Id == request.Id)!);
            return Task.FromResult(Unit.Value);
        }
    }
}