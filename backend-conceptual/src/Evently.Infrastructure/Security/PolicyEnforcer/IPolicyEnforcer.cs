using ErrorOr;
using Evently.Application.Common.Security.Request;
using Evently.Infrastructure.Security.CurrentUserProvider;

namespace Evently.Infrastructure.Security.PolicyEnforcer;

public interface IPolicyEnforcer
{
    public ErrorOr<Success> Authorize<T>(
        IAuthorizeableRequest<T> request,
        CurrentUser currentUser,
        string policy);
}