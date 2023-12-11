
using Project.Domain.Models;

namespace Project.eTicketTests.MockData
{
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
}
