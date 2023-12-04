using Project.Domain.Models;

namespace Application.Repositories
{
    public interface IEventRepository
    {
        Event GetById(Guid id);
        IEnumerable<Event> GetAll();
        void Add(Event newEvent);
        void Update(Event newEvent);
        void Delete(Guid id);
    }
}
