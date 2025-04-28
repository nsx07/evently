using Evently.Application.Common.Security.Permissions;
using Evently.Application.Common.Security.Policies;
using Evently.Application.Common.Security.Request;
using Evently.Application.Subscriptions.Common;
using Evently.Domain.Users;

using ErrorOr;

namespace Evently.Application.Subscriptions.Commands.CreateSubscription;

[Authorize(Permissions = Permission.Subscription.Create, Policies = Policy.SelfOrAdmin)]
public record CreateSubscriptionCommand(
    Guid UserId,
    string FirstName,
    string LastName,
    string Email,
    SubscriptionType SubscriptionType)
    : IAuthorizeableRequest<ErrorOr<SubscriptionResult>>;