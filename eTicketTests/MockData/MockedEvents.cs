
using Application.Commands;
using Project.Domain.Enums;

public static class MockedEvents
{
    public static CreateEventCommand EventOrganizerEmail_Is_Empty()
    {
        return new CreateEventCommand
        {
            EventName = "Test Event",
            EventLocation = "Test Location",
            EventDescription = "Test Description",
            EventOrganizer = "Test Organizer",
            EventOrganizerEmail = "",
            EventOrganizerContact = "Test Contact",
            EventType = EventType.Conference
        };
    }

    public static CreateEventCommand MockEvent2()
    {
        return new CreateEventCommand
        {
            EventName = "Test Event",
            EventLocation = "Test Location",
            EventDescription = "Test Description",
            EventOrganizer = "Test Organizer",
            EventOrganizerEmail = "",
        };
    }

    public static CreateEventCommand MockEvent3()
    {
        return new CreateEventCommand
        {
            EventName = "Test Event",
            EventLocation = "Test Location",
            EventDescription = "Test Description",
            EventOrganizer = "Test Organizer",
            EventOrganizerEmail = "",
        };
    }
}
