using Evently.Application.Common.Security.Permissions;
using Evently.Application.Common.Security.Policies;
using Evently.Application.Common.Security.Request;
using Evently.Domain.Reminders;

using ErrorOr;

namespace Evently.Application.Reminders.Queries.GetReminder;

[Authorize(Permissions = Permission.Reminder.Get, Policies = Policy.SelfOrAdmin)]
public record GetReminderQuery(Guid UserId, Guid SubscriptionId, Guid ReminderId) : IAuthorizeableRequest<ErrorOr<Reminder>>;