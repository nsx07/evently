using Evently.Domain.User;
using Evently.Domain.User.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Evently.Infra.Persistence.Repositories.User
{
    public class UserRepository(EFContext context) : IUserRepository
    {
        private readonly EFContext _context = context;

        public async Task<IEnumerable<Domain.User.User>> GetAllUsers()
        {
            return await _context.User.AsQueryable().ToListAsync();
        }

        public async Task<Domain.User.User?> GetUserByEmail(string email)
        {
            return await _context.User
                .AsQueryable()
                .FirstOrDefaultAsync(x => x.Email == email);
        }

        public Task<Domain.User.User?> GetUserById(Guid id)
        {
            return _context.User
                .AsQueryable()
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<Domain.User.User?> GetUserByPhone(string phone)
        {
            return _context.User
                .AsQueryable()
                .FirstOrDefaultAsync(x => x.Phone == phone);
        }
    }
}
