using Application.Repositories;
using eTicketTests.Scrubs;
using Moq;
using Project.Domain.Models;
using Project.eTicketTests.MockData;

namespace eTicketTests;

public class EventTests
{
    [Fact]
    public async Task CreateEvent_WhenValidation_UnSuccessful()
    {
        //Arrange
        var createEventCommandMock = MockedEvents.EventOrganizerEmail_Is_Empty();
        var eventRepositoryMock = new Mock<IEventRepository>();

        //Assert
        // TODO: Add assertions
        var createEventCommandHandlerStub = new CreateEventCommandHandlerStub().CreateStub(eventRepositoryMock: eventRepositoryMock);
        Func<Task> action = async () => await createEventCommandHandlerStub.Handle(createEventCommandMock, new CancellationToken());

        //Assert
        eventRepositoryMock.Verify(x => x.AddAsync(It.IsAny<Event>()), Times.Never);
        await Assert.ThrowsAsync<FluentValidation.ValidationException>(action);

    }

    [Fact]
    public async Task CreateEvent_WhenValidation_Successful()
    {
        //Arrange
        var createEventCommandMock = MockedEvents.CreateEvent_Success();
        var eventRepositoryMock = new Mock<IEventRepository>();
        var organizer = MockOrganizers.CreateMockOrganizers().First();
        eventRepositoryMock.Setup(x => x.GetOrganizerById(It.IsAny<Guid>())).Returns(organizer);
        
        var createEventCommandHandlerStub = new CreateEventCommandHandlerStub().CreateStub(eventRepositoryMock: eventRepositoryMock);
        
        //Act
        await createEventCommandHandlerStub.Handle(createEventCommandMock, new CancellationToken());

        //Assert
        eventRepositoryMock.Verify(x => x.AddAsync(It.IsAny<Event>()), Times.Once);
    }

    [Fact]

    public async Task CreateEvent_Failed_WhenOrganizerId_Does_Not_Exist()
    {
        //Arrange
        var createEventCommandMock = MockedEvents.CreateEvent_Success();
        var eventRepositoryMock = new Mock<IEventRepository>();
        eventRepositoryMock.Setup(x => x.GetOrganizerById(It.IsAny<Guid>())).Returns((Organizer)null);
        var createEventCommandHandlerStub = new CreateEventCommandHandlerStub().CreateStub(eventRepositoryMock: eventRepositoryMock);
        //Act
        var action = async () => await createEventCommandHandlerStub.Handle(createEventCommandMock, new CancellationToken());

        //Assert
        await Assert.ThrowsAsync<FluentValidation.ValidationException>(action.Invoke);
        eventRepositoryMock.Verify(x => x.AddAsync(It.IsAny<Event>()), Times.Never);
    }
}