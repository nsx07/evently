using Evently.Domain.Common;
using Evently.Domain.Reminders;

namespace Evently.Domain.Users.Events;

public record ReminderSetEvent(Reminder Reminder) : IDomainEvent;