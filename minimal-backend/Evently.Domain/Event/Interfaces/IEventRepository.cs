using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evently.Domain.Event.Interfaces
{
    public interface IEventRepository
    {
        Task<Event?> GetEventByIdAsync(Guid id);
        Task<IEnumerable<Event>> GetAllEventsAsync();
        Task AddEventAsync(Event eventEntity);
        Task RemoveEventAsync(Guid id);
    }
}
