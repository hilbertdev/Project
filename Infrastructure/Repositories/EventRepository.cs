namespace Infrastructure.Repositories;
using Project.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Project.Infrastructure;

public class EventRepository(AutoTicketContext context) : IEventRepository
{
    private readonly AutoTicketContext context = context;

    public async Task<SocialEvent?> GetEventById(Guid eventId)
    {
        var eventEntity = await this.context.Events.FirstOrDefaultAsync(x => x.Id == eventId);
        return eventEntity;
    }

    public async Task<SocialEvent?> GetEventByName(string eventName)
    {
        var eventEntity = await this.context.Events.FirstOrDefaultAsync(x => eventName.Equals(x.EventName, StringComparison.OrdinalIgnoreCase));
        return eventEntity;
    }

    public async Task<ICollection<SocialEvent>> GetAllEvents()
    {
        var events = await this.context.Events.ToListAsync();
        return events;
    }

    public async Task CreateEvent(SocialEvent eventEntity)
    {
        await this.context.Events.AddAsync(eventEntity);
        await this.context.SaveChangesAsync();
    }
    public async Task<Organizer?> GetOrganizerById(Guid id) => await this.context.Organizers.FirstOrDefaultAsync(x => x.Id == id);

    public SocialEvent GetById(Guid id) => throw new NotImplementedException();

    public IEnumerable<SocialEvent> GetAll() => throw new NotImplementedException();
    public void Add(SocialEvent newEvent) => throw new NotImplementedException();
    public void Update(SocialEvent newEvent) => throw new NotImplementedException();
    public void Delete(Guid id) => throw new NotImplementedException();
    public Task<SocialEvent?> GetByIdAsync(Guid id) => throw new NotImplementedException();
    public Task<IEnumerable<SocialEvent>> GetAllAsync() => throw new NotImplementedException();
    public Task AddAsync(SocialEvent newEvent) => throw new NotImplementedException();
    public Task UpdateAsync(SocialEvent newEvent) => throw new NotImplementedException();
    public Task DeleteAsync(Guid id) => throw new NotImplementedException();
    public Task<SocialEvent?> GetEventById(int eventId) => throw new NotImplementedException();
    public Task<Venue> GetVenueById(Guid value) => throw new NotImplementedException();
}