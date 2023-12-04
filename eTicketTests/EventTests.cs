using Application.Commands;

namespace eTicketTests;

public class EventTests
{
    [Fact]
    public void CreateEvent_WhenValidationIsSuccessful()
    {
        var createEventCommandMock = MockedEvents.MockEvent1();
        var validator = new CreateEventCommandValidator();

        
        var result = validator.Validate(createEventCommandMock);

    }
}