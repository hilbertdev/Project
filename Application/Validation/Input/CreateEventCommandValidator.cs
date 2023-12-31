using Application.Commands;
using FluentValidation;

public sealed class CreateEventCommandValidator : AbstractValidator<CreateEventCommand>
{
    public CreateEventCommandValidator()
    {
        RuleFor(x => x.EventName)
            .NotEmpty().WithMessage("Event name is required.")
            .MaximumLength(50).WithMessage("Event name cannot exceed 50 characters.");

        RuleFor(x => x.EventLocation)
            .NotEmpty().WithMessage("Event location is required.")
            .MaximumLength(100).WithMessage("Event location cannot exceed 100 characters.");
        
        RuleFor(x => x.EventDescription)
            .NotEmpty().WithMessage("Event description is required.")
            .MaximumLength(500).WithMessage("Event description cannot exceed 500 characters.");

        RuleFor(x => x.EventOrganizerContact)
            .NotEmpty().WithMessage("Event organizer contact is required.")
            .MaximumLength(13).WithMessage("Event organizer contact cannot exceed 13 characters.");
        
        RuleFor(x => x.EventType)
            .IsInEnum().WithMessage("Event type is not valid.");
    }
}
