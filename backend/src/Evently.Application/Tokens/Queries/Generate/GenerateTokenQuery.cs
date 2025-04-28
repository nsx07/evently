using ErrorOr;
using Evently.Application.Authentication.Queries.Login;
using Evently.Domain.Users;
using MediatR;

namespace Evently.Application.Tokens.Queries.Generate;

public record GenerateTokenQuery(
    Guid? Id,
    string FirstName,
    string LastName,
    string Email,
    SubscriptionType SubscriptionType,
    List<string> Permissions,
    List<string> Roles) : IRequest<ErrorOr<GenerateTokenResult>>;