using ErrorOr;
using Evently.Application.Common.Security.Permissions;
using Evently.Application.Common.Security.Policies;
using Evently.Application.Common.Security.Request;
using Evently.Application.Subscriptions.Common;

namespace Evently.Application.Subscriptions.Queries.GetSubscription;

[Authorize(Permissions = Permission.Subscription.Get, Policies = Policy.SelfOrAdmin)]
public record GetSubscriptionQuery(Guid UserId)
    : IAuthorizeableRequest<ErrorOr<SubscriptionResult>>;