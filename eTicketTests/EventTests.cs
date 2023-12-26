namespace eTicketTests;
using Application.Repositories;
using Domain.Models;
using eTicketTests.MockData;
using eTicketTests.Scrubs;
using Moq;
using Project.Domain.Models;
using Project.eTicketTests.MockData;

public class EventTests
{
    [Fact]
    public async Task CreateEventWhenValidationUnSuccessful()
    {
        //Arrange
        var createEventCommandMock = MockedEvents.EventOrganizerEmailIsEmpty();
        var eventRepositoryMock = new Mock<IEventRepository>();

        //Assert
        // TODO: Add assertions
        var createEventCommandHandlerStub = new CreateEventCommandHandlerStub().CreateStub(eventRepositoryMock: eventRepositoryMock);
        Func<Task> action = async () => await createEventCommandHandlerStub.Handle(createEventCommandMock, new CancellationToken());

        //Assert
        eventRepositoryMock.Verify(x => x.AddAsync(It.IsAny<SocialEvent>()), Times.Never);
        await Assert.ThrowsAsync<FluentValidation.ValidationException>(action);

    }

    [Fact]
    public async Task CreateEventWhenValidationSuccessful()
    {
        //Arrange
        var createEventCommandMock = MockedEvents.CreateEventSuccess();
        var eventRepositoryMock = new Mock<IEventRepository>();
        var organizer = MockOrganizers.CreateMockOrganizers().First();
        var venue = MockedVenues.CreateVenueSuccess();

        eventRepositoryMock.Setup(x => x.GetVenueById(It.IsAny<Guid>())).ReturnsAsync(venue);
        eventRepositoryMock.Setup(x => x.GetOrganizerById(It.IsAny<Guid>())).ReturnsAsync(organizer);

        var createEventCommandHandlerStub = new CreateEventCommandHandlerStub().CreateStub(eventRepositoryMock: eventRepositoryMock);

        //Act
        await createEventCommandHandlerStub.Handle(createEventCommandMock, new CancellationToken());

        //Assert
        eventRepositoryMock.Verify(x => x.AddAsync(It.IsAny<SocialEvent>()), Times.Once);
    }

    [Fact]

    public async Task CreateEventFailedWhenOrganizerIdDoesNotExist()
    {
        //Arrange
        var createEventCommandMock = MockedEvents.CreateEventSuccess();
        var eventRepositoryMock = new Mock<IEventRepository>();
        eventRepositoryMock.Setup(x => x.GetOrganizerById(It.IsAny<Guid>())).ReturnsAsync((Organizer)null);
        var createEventCommandHandlerStub = new CreateEventCommandHandlerStub().CreateStub(eventRepositoryMock: eventRepositoryMock);
        //Act
        var action = async () => await createEventCommandHandlerStub.Handle(createEventCommandMock, new CancellationToken());

        //Assert
        await Assert.ThrowsAsync<FluentValidation.ValidationException>(action.Invoke);
        eventRepositoryMock.Verify(x => x.AddAsync(It.IsAny<SocialEvent>()), Times.Never);
    }

    [Fact]
    public async Task CreateEventFailedWhenVenueIdDoesNotExist()
    {
        //Arrange
        var createEventCommandMock = MockedEvents.CreateEventSuccess();
        var eventRepositoryMock = new Mock<IEventRepository>();
        var organizer = MockOrganizers.CreateMockOrganizers().First();
        eventRepositoryMock.Setup(x => x.GetOrganizerById(It.IsAny<Guid>())).ReturnsAsync(organizer);
        eventRepositoryMock.Setup(x => x.GetVenueById(It.IsAny<Guid>())).ReturnsAsync((Venue)null);
        var createEventCommandHandlerStub = new CreateEventCommandHandlerStub().CreateStub(eventRepositoryMock: eventRepositoryMock);
        //Act
        var action = async () => await createEventCommandHandlerStub.Handle(createEventCommandMock, new CancellationToken());

        //Assert
        await Assert.ThrowsAsync<FluentValidation.ValidationException>(action.Invoke);
        eventRepositoryMock.Verify(x => x.AddAsync(It.IsAny<SocialEvent>()), Times.Never);
    }
}