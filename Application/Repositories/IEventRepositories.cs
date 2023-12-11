using Project.Domain.Models;

namespace Application.Repositories
{
    public interface IEventRepository
    {
        Event GetById(Guid id);
        Organizer GetOrganizerById(Guid id);
        IEnumerable<Event> GetAll();
        void Add(Event newEvent);
        void Update(Event newEvent);
        void Delete(Guid id);
        Task<Event> GetByIdAsync(Guid id);
        Task<IEnumerable<Event>> GetAllAsync();
        Task AddAsync(Event newEvent);
        Task UpdateAsync(Event newEvent);
        Task DeleteAsync(Guid id);
        Task<Event> GetEventById(int eventId);
    }
}
