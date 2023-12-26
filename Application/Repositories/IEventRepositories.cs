namespace Application.Repositories;
using Domain.Models;
using Project.Domain.Models;

public interface IEventRepository
{
    SocialEvent GetById(Guid id);
    Task<Organizer> GetOrganizerById(Guid id);
    IEnumerable<SocialEvent> GetAll();
    void Add(SocialEvent newEvent);
    void Update(SocialEvent newEvent);
    void Delete(Guid id);
    Task<SocialEvent> GetByIdAsync(Guid id);
    Task<IEnumerable<SocialEvent>> GetAllAsync();
    Task AddAsync(SocialEvent newEvent);
    Task UpdateAsync(SocialEvent newEvent);
    Task DeleteAsync(Guid id);
    Task<SocialEvent> GetEventById(int eventId);
    Task<Venue> GetVenueById(Guid value);
}
