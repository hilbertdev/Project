namespace eTicketTests.MockData;
using Domain.Models;

public static class MockedVenues
{
    public static Venue CreateVenueSuccess() => new("Test Venue", "Test Address", null, null, null, null, null, null);
}