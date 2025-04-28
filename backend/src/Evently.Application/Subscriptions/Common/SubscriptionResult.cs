using Evently.Domain.Users;

using Throw;

namespace Evently.Application.Subscriptions.Common;

public record SubscriptionResult(
    Guid Id,
    Guid UserId,
    SubscriptionType SubscriptionType)
{
    public static SubscriptionResult FromUser(User user)
    {
        user.Subscription.ThrowIfNull();

        return new SubscriptionResult(
            user.Subscription.Id,
            user.Id,
            user.Subscription.SubscriptionType);
    }
}