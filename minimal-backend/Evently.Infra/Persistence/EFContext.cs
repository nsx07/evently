using Evently.Domain.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Evently.Infra.Persistence
{

    public class EFContextFactory : IDesignTimeDbContextFactory<EFContext>
    {
        public EFContext CreateDbContext(string[] args)
        {
            SQLitePCL.Batteries.Init();
            return new EFContext();
        }
    }

    public class EFContext : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=\"C:\\Development\\evently\\minimal-backend\\Evently.Infra\\Evently.db\"");
        }
    }
}
