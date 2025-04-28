using Evently.Application.Common.Security.Request;
using Evently.Infrastructure.Security.CurrentUserProvider;

using ErrorOr;

namespace Evently.Infrastructure.Security.PolicyEnforcer;

public interface IPolicyEnforcer
{
    public ErrorOr<Success> Authorize<T>(
        IAuthorizeableRequest<T> request,
        CurrentUser currentUser,
        string policy);
}