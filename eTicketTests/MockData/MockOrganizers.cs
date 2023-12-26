namespace Project.eTicketTests.MockData;

using Project.Domain.Models;

public static class MockOrganizers
{
    public static List<Organizer> CreateMockOrganizers()
    {
        List<Organizer> organizers =
        [
            new Organizer(Guid.NewGuid()),
            new Organizer(Guid.NewGuid()),
            new Organizer(Guid.NewGuid()),
        ];

        return organizers;
    }
}
