using Evently.Domain.Common;

namespace Evently.Domain.Users.Events;

public record ReminderDeletedEvent(Guid ReminderId) : IDomainEvent;