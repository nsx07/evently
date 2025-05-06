using Evently.Domain.Event;
using Evently.Domain.Ticket;
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
        public DbSet<Organizer> Organizer { get; set; }
        public DbSet<Attendee> Attendee { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<TicketOrder> TicketOrder { get; set; }
        public DbSet<TicketOrderPayment> TicketOrderPayment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=\"C:\\Development\\evently\\minimal-backend\\Evently.Infra\\Evently.db\"");
        }
    }
}
