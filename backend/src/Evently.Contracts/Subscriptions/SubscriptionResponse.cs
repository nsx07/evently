using Evently.Contracts.Common;

namespace Evently.Contracts.Subscriptions;

public record SubscriptionResponse(
    Guid Id,
    Guid UserId,
    SubscriptionType SubscriptionType);