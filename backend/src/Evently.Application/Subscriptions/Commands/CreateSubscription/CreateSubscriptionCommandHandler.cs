using ErrorOr;
using Evently.Application.Common.Interfaces;
using Evently.Application.Subscriptions.Common;
using Evently.Domain.Subscriptions;
using Evently.Domain.Users;
using MediatR;

namespace Evently.Application.Subscriptions.Commands.CreateSubscription;

public class CreateSubscriptionCommandHandler(
    IUsersRepository _usersRepository) : IRequestHandler<CreateSubscriptionCommand, ErrorOr<SubscriptionResult>>
{
    public async Task<ErrorOr<SubscriptionResult>> Handle(CreateSubscriptionCommand request, CancellationToken cancellationToken)
    {
        if (await _usersRepository.GetByIdAsync(request.UserId, cancellationToken) is not null)
        {
            return Error.Conflict(description: "User already has an active subscription");
        }

        var subscription = new Subscription(request.SubscriptionType);

        var user = new User(
            request.UserId,
            request.FirstName,
            request.LastName,
            request.Email,
            subscription);

        await _usersRepository.AddAsync(user, cancellationToken);

        return SubscriptionResult.FromUser(user);
    }
}
