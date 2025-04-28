using Evently.Domain.Common;

namespace Evently.Domain.Users.Events;

public record ReminderDismissedEvent(Guid ReminderId) : IDomainEvent;