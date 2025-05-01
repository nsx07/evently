using Evently.Domain.User.Interfaces;
using Evently.Infra.Persistence;
using Evently.Infra.Persistence.Interfaces;
using Evently.Infra.Persistence.Repositories;
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
        }

        private static void AddServices(IServiceCollection services)
        {
        }
    }
}
