using Evently.Application.Common.Security.Permissions;
using Evently.Application.Common.Security.Policies;
using Evently.Application.Common.Security.Request;
using Evently.Domain.Reminders;

using ErrorOr;

namespace Evently.Application.Reminders.Commands.SetReminder;

[Authorize(Permissions = Permission.Reminder.Set, Policies = Policy.SelfOrAdmin)]
public record SetReminderCommand(Guid UserId, Guid SubscriptionId, string Text, DateTime DateTime)
    : IAuthorizeableRequest<ErrorOr<Reminder>>;