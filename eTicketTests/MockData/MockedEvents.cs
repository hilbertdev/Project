
using Application.Commands;
using Project.Domain.Enums;
using Project.Domain.Primitives.ValueObjects;

public static class MockedEvents
{
    public static CreateEventCommand EventOrganizerEmail_Is_Empty()
    {
        return new CreateEventCommand
        {
            EventName = "Test Event",
            EventLocation = "Test Location",
            EventDescription = "Test Description",
            EventOrganizerEmail = new Email("test@gmail.com"),
            EventOrganizerContact = "",
            EventType = EventType.Conference
        };
    }

    public static CreateEventCommand CreateEvent_Success()
    {
        return new CreateEventCommand
        {
            OrganizerId = Guid.NewGuid(),
            EventName = "Test Event",
            EventLocation = "Test Location",
            EventDescription = "Test Description",
            EventOrganizerEmail = new Email("test@gmail.com"),
            EventOrganizerContact = "0734714183",
            EventType = EventType.Seminar
        };
    }

    public static CreateEventCommand MockEvent3()
    {
        return new CreateEventCommand
        {
            EventName = "Test Event",
            EventLocation = "Test Location",
            EventDescription = "Test Description",
            EventOrganizerEmail = new Email("test@gmail.com"),
            EventOrganizerContact = "Test Contact",
            EventType = EventType.Social
        };
    }
}
