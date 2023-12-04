
using Application.Commands;

public static class MockedEvents
{
    public static CreateEventCommand MockEvent1()
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
