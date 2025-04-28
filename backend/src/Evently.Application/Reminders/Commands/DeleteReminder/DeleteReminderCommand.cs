using ErrorOr;

using Evently.Application.Common.Security.Permissions;
using Evently.Application.Common.Security.Policies;
using Evently.Application.Common.Security.Request;

namespace Evently.Application.Reminders.Commands.DeleteReminder;

[Authorize(Permissions = Permission.Reminder.Delete, Policies = Policy.SelfOrAdmin)]
public record DeleteReminderCommand(Guid UserId, Guid SubscriptionId, Guid ReminderId)
    : IAuthorizeableRequest<ErrorOr<Success>>;