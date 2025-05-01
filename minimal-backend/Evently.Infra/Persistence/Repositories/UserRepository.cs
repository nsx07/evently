using Evently.Domain.User;
using Evently.Domain.User.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evently.Infra.Persistence.Repositories
{
    public class UserRepository(EFContext context) : IUserRepository
    {
        private readonly EFContext _context = context;

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _context.User.AsQueryable().ToListAsync();
        }

        public async Task<User?> GetUserByEmail(string email)
        {
            return await _context.User
                .AsQueryable()
                .FirstOrDefaultAsync(x => x.Email == email);
        }

        public Task<User?> GetUserById(Guid id)
        {
            return _context.User
                .AsQueryable()
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<User?> GetUserByPhone(string phone)
        {
            return _context.User
                .AsQueryable()
                .FirstOrDefaultAsync(x => x.Phone == phone);
        }
    }
}
