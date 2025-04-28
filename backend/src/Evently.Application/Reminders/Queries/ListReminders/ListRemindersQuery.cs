using ErrorOr;
using Evently.Application.Common.Security.Permissions;
using Evently.Application.Common.Security.Policies;
using Evently.Application.Common.Security.Request;
using Evently.Domain.Reminders;

namespace Evently.Application.Reminders.Queries.ListReminders;

[Authorize(Permissions = Permission.Reminder.Get, Policies = Policy.SelfOrAdmin)]
public record ListRemindersQuery(Guid UserId, Guid SubscriptionId) : IAuthorizeableRequest<ErrorOr<List<Reminder>>>;