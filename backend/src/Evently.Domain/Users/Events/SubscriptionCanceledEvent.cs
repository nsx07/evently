using Evently.Domain.Common;

namespace Evently.Domain.Users.Events;

public record SubscriptionCanceledEvent(User User, Guid SubscriptionId) : IDomainEvent;