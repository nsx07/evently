using Evently.Domain.Common;

namespace Evently.Domain.Users;

public class User : Entity
{
    public string Email { get; } = null!;
    public string FirstName { get; } = null!;
    public string LastName { get; } = null!;
    public Role Role { get; } = null!;

    public User(
        Guid id,
        string firstName,
        string lastName,
        string email)
            : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    private User()
    {
    }
}