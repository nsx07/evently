using Evently.Application.Services.Event.ViewModel;

namespace Evently.Application.Services.Event.Interface
{
    public interface IEventService
    {
        Task<string> CreateEvent(CreateEventViewModel model);
        Task<Domain.Event.Event?> GetEventById(Guid id);
        Task<IEnumerable<Domain.Event.Event>> GetEvents();
        Task RemoveEvent(Guid id);
    }
}
