using System.ComponentModel.DataAnnotations;
using Application.Commands;
using Application.Repositories;
using AutoMapper;
using eTicketTests.Scrubs;
using Moq;
using Project.Domain.Models;

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
        var mapperMock = new Mock<IMapper>();
        var createEventCommandHandlerStub = new CreateEventCommandHandlerStub().CreateStub(eventRepositoryMock: eventRepositoryMock, mapperMock: mapperMock);
        Func<Task> action = async () => await createEventCommandHandlerStub.Handle(createEventCommandMock, new CancellationToken());

        //Assert
        eventRepositoryMock.Verify(x => x.AddAsync(It.IsAny<Event>()), Times.Never);
        mapperMock.Verify(x => x.Map<Event>(It.IsAny<CreateEventCommand>()), Times.Never);
        await Assert.ThrowsAsync<FluentValidation.ValidationException>(action);

    }
}