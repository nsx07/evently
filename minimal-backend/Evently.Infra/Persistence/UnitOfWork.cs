using Evently.Application.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;

namespace Evently.Infra.Persistence
{
    public class UnitOfWork(EFContext context) : IUnitOfWork<IDbContextTransaction>
    {
        private readonly EFContext _context = context;

        public IDbContextTransaction BeginTransaction()
        {
            return _context.Database.BeginTransaction();
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}
