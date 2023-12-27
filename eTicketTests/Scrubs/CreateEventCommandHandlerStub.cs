namespace eTicketTests.Scrubs;
using Application.Handlers.CommandHandler;
using Application.UseCases.SocialEvents.Commands;
using Application.Validation.Input;
using FluentValidation;
using Infrastructure.Repositories;
using Moq;

public class CreateEventCommandHandlerStub
{
    private readonly Mock<IEventRepository> eventRepositoryMock = new();
    private readonly Mock<IValidator<CreateEventCommand>> validatorMock = new();

    public CreateEventCommandHandler CreateStub(Mock<IEventRepository>? eventRepositoryMock = null, Mock<IValidator<CreateEventCommand>>? validatorMock = null) => new(
            eventRepositoryMock?.Object ?? this.eventRepositoryMock.Object,
            validatorMock?.Object ?? this.validatorMock.Object
        );

    public CreateEventCommandHandler CreateStub(Mock<IEventRepository>? eventRepositoryMock = null)
    {
        var eventValidator = new CreateEventCommandValidator();
        return new CreateEventCommandHandler(
            eventRepositoryMock?.Object ?? this.eventRepositoryMock.Object,
            eventValidator
        );
    }
}
