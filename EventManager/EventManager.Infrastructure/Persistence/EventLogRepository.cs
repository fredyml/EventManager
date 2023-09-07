using EventManager.Application.Interfaces;
using EventManager.Domain.Entities;

namespace EventManager.Infrastructure.Persistence
{
    public class EventLogRepository : IEventLogRepository
    {
        private readonly RegistrationDbContext _context;

        public EventLogRepository(RegistrationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(EventLog eventLog)
        {
            _context.EventLogs.Add(eventLog);
            await _context.SaveChangesAsync();
        }

        public IQueryable<EventLog> GetEvents()
        {
            return _context.EventLogs.AsQueryable();
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
    }

}
