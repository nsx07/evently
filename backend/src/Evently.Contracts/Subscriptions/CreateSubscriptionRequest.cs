using Evently.Contracts.Common;

namespace Evently.Contracts.Subscriptions;

public record CreateSubscriptionRequest(
    string FirstName,
    string LastName,
    string Email,
    SubscriptionType SubscriptionType);