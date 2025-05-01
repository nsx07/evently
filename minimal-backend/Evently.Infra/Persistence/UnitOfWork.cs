using Evently.Infra.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
