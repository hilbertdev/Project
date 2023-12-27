namespace Project.eTicketTests.MockData;

using Application.UseCases.SocialEvents.Commands;
using Project.Domain.Enums;
using Project.Domain.Primitives.ValueObjects;

public static class MockedEvents
{
    public static CreateEventCommand EventOrganizerEmailIsEmpty() => new()
    {
        EventName = "Test Event",
        VenueId = Guid.NewGuid(),
        EventDescription = "Test Description",
        EventOrganizerEmail = "test@gmail.com",
        EventOrganizerContact = "",
        EventType = EventType.Conference
    };

    public static CreateEventCommand CreateEventSuccess() => new()
    {
        OrganizerId = Guid.NewGuid(),
        EventName = "Test Event",
        VenueId = Guid.NewGuid(),
        EventDescription = "Test Description",
        EventOrganizerEmail = "test@gmail.com",
        EventOrganizerContact = "0734714183",
        EventType = EventType.Seminar
    };

    public static CreateEventCommand MockEvent3() => new()
    {
        EventName = "Test Event",
        VenueId = Guid.NewGuid(),
        EventDescription = "Test Description",
        EventOrganizerEmail = "test@gmail.com",
        EventOrganizerContact = "Test Contact",
        EventType = EventType.Social
    };

    public static CreateEventCommand VenueIdIsNullException() => new()
    {
        EventName = "Test Event",
        VenueId = null,
        EventDescription = "Test Description",
        EventOrganizerEmail = "test@gmail.com",
        EventOrganizerContact = "Test Contact",
        EventType = EventType.Social
    };
}
