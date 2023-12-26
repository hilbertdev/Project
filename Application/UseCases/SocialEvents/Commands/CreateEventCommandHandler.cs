namespace Application.Handlers.CommandHandler;

using Application.Repositories;
using Application.UseCases.SocialEvents.Commands;
using FluentValidation;
using MediatR;

public class CreateEventCommandHandler(IEventRepository eventRepository, IValidator<CreateEventCommand> validator) : IRequestHandler<CreateEventCommand>
{
    /// <summary>
    /// Represents the event repository used for data access.
    /// </summary>
    private readonly IEventRepository eventRepository = eventRepository;


    /// <summary>
    /// The validator used to validate the <see cref="CreateEventCommand"/> object.
    /// </summary>
    private readonly IValidator<CreateEventCommand> validator = validator;

    public async Task<Unit> Handle(CreateEventCommand request, CancellationToken cancellationToken)
    {
        var validationResult = this.validator.Validate(request);

        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }

        var organizer = await this.eventRepository.GetOrganizerById(request.OrganizerId!.Value) ?? throw new ValidationException("Please register as an organizer first.");
        var venue = await this.eventRepository.GetVenueById(request.VenueId!.Value) ?? throw new ValidationException("Please register a venue first.");

        organizer.CreateEvent(
            request.Id,
            request.EventName!,
            request.EventType,
            venue.Id,
            request.EventDescription!,
            request.EventOrganizerEmail!,
            request.EventOrganizerContact!);

        _ = this.eventRepository.AddAsync(organizer.GetEvents().FirstOrDefault(x => x.Id == request.Id)!);
        return await Task.FromResult(Unit.Value);
    }
}