namespace eTicketTests.MockData;
using Project.Domain.Models;

public static class MockedVenues
{
    public static Venue CreateVenueSuccess() => new("Test Venue", "Test Address", null, null, null, null, null, null);
}