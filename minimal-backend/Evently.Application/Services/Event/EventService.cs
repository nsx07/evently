using Evently.Application.Interfaces;
using Evently.Application.Services.Event.Interface;
using Evently.Application.Services.Event.ViewModel;
using Evently.Domain.Event;
using Evently.Domain.Event.Interfaces;
using Evently.Shared.Core.Assertion;
using Microsoft.EntityFrameworkCore.Storage;

namespace Evently.Application.Services.Event
{
    public class EventService(IEventRepository eventRepository, IUnitOfWork<IDbContextTransaction> unitOfWork) : IEventService
    {
        public async Task<string> CreateEvent(CreateEventViewModel model)
        {
            var transaction = unitOfWork.BeginTransaction();

            var eventEntity = new Domain.Event.Event
            {
                EndDate = model.EndDate,
                StartDate = model.StartDate,
                Title = model.Title,
                Location = model.Location,
                PrincipalImageUrl = model.PrincipalImageUrl,
                Description = model.Description,
                IsOnline = model.IsOnline,
                IsActive = model.IsActive,
                IsOnlyAdults = model.IsOnlyAdults,
                MaxAttendees = model.MaxAttendees
            };

            await eventRepository.AddEventAsync(eventEntity);
            await unitOfWork.Commit();
            await transaction.CommitAsync();

            return eventEntity.Id.ToString();
        }

        public async Task<IEnumerable<Domain.Event.Event>> GetEvents()
        {
            return await eventRepository.GetAllEventsAsync();
        }

        public async Task<Domain.Event.Event?> GetEventById (Guid id)
        {
            var eventExistent = await eventRepository.GetEventByIdAsync(id);
            AssertionConcern.AssertArgumentNotNull(eventExistent, "Event not found");
            return eventExistent;
        }

        public async Task RemoveEvent(Guid id)
        {
            var eventExistent = await eventRepository.GetEventByIdAsync(id);
            AssertionConcern.AssertArgumentNotNull(eventExistent, "Event not found");

            var transaction = unitOfWork.BeginTransaction();
            
            await eventRepository.RemoveEventAsync(id);
            await unitOfWork.Commit();

            await transaction.CommitAsync();
        }
    }
}
