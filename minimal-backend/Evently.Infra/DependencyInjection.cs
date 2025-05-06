using Evently.Application.Interfaces;
using Evently.Application.Services.Event;
using Evently.Application.Services.Event.Interface;
using Evently.Domain.Event.Interfaces;
using Evently.Domain.User.Interfaces;
using Evently.Infra.Persistence;
using Evently.Infra.Persistence.Repositories.Event;
using Evently.Infra.Persistence.Repositories.User;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;

namespace Evently.Infra
{
    public static class DependencyInjection
    {
        public static IServiceCollection Setup(this IServiceCollection services)
        {
            AddDatabase(services);
            AddRepositories(services);
            AddServices(services);
            return services;
        }

        private static void AddDatabase(IServiceCollection services)
        {
            services.AddDbContext<EFContext>();
            services.AddTransient<IUnitOfWork<IDbContextTransaction>, UnitOfWork>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IEventRepository, EventRepository>();
        }

        private static void AddServices(IServiceCollection services)
        {
            // services.AddTransient<IUserService, UserService>();
             services.AddScoped<IEventService, EventService>();
            // services.AddTransient<ITicketService, TicketService>();
            // services.AddTransient<ITicketOrderService, TicketOrderService>();
            // services.AddTransient<ITicketOrderPaymentService, TicketOrderPaymentService>();
        }
    }
}
