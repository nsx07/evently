namespace Evently.Application.Authentication.Queries.Login;

public record GenerateTokenResult(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token);