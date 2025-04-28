using Evently.Application.Common.Security.Permissions;
using Evently.Application.Common.Security.Policies;
using Evently.Application.Common.Security.Request;

using ErrorOr;

namespace Evently.Application.Reminders.Commands.DismissReminder;

[Authorize(Permissions = Permission.Reminder.Dismiss, Policies = Policy.SelfOrAdmin)]
public record DismissReminderCommand(Guid UserId, Guid SubscriptionId, Guid ReminderId)
    : IAuthorizeableRequest<ErrorOr<Success>>;