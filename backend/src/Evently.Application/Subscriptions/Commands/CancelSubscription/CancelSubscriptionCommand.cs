using ErrorOr;
using Evently.Application.Common.Security.Request;
using Evently.Application.Common.Security.Roles;

namespace Evently.Application.Subscriptions.Commands.CancelSubscription;

[Authorize(Roles = Role.Admin)]
public record CancelSubscriptionCommand(Guid UserId, Guid SubscriptionId) : IAuthorizeableRequest<ErrorOr<Success>>;