using Evently.Domain.Event.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Evently.Infra.Persistence.Repositories.Event
{
    public class EventRepository(EFContext context) : IEventRepository
    {
        private readonly EFContext _context = context;

        public async Task<IEnumerable<Domain.Event.Event>> GetAllEventsAsync()
        {
            return await _context.Event
                .AsQueryable().ToListAsync();
        }

        public async Task<Domain.Event.Event?> GetEventByIdAsync(Guid id)
        {
            return await _context.Event
                    .Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task AddEventAsync(Domain.Event.Event eventEntity)
        {
            await _context.Event.AddAsync(eventEntity);
        }

        public async Task RemoveEventAsync(Guid id)
        {
            await _context.Database.ExecuteSqlRawAsync("DELETE FROM Event WHERE Id = {0}", id);
        }
    }
}
