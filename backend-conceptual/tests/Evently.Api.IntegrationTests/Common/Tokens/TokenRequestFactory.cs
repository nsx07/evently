using Evently.Contracts.Tokens;

namespace Evently.Api.IntegrationTests.Common.Tokens;

public static class TokenRequestFactory
{
    public static GenerateTokenRequest CreateGenerateTokenRequest(
        Guid? id = null,
        string firstName = Constants.User.FirstName,
        string lastName = Constants.User.LastName,
        string email = Constants.User.Email,
        List<string>? permissions = null,
        List<string>? roles = null)
    {
        return new(
            id ?? Constants.User.Id,
            firstName,
            lastName,
            email,
            permissions ?? Constants.User.Permissions,
            roles ?? Constants.User.Roles);
    }
}