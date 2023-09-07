using EventManager.Domain.Entities;

namespace EventManager.Application.Interfaces
{
    public interface IEventLogRepository
    {
        Task AddAsync(EventLog eventLog);
        Task SaveChangesAsync();
        IQueryable<EventLog> GetEvents();
    }
}