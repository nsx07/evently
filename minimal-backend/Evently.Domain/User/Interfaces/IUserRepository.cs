namespace Evently.Domain.User.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetUserById(Guid id);
        Task<User?> GetUserByEmail(string email);
        Task<User?> GetUserByPhone(string phone);
        Task<IEnumerable<User>> GetAllUsers();
    }
}
