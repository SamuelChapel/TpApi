using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TpApi.Repository.Contracts;
using TpApi.Repository.Database.Contexts;
using TpApi.Repository.Database.Repositories;

namespace TpApi.Api.Extensions;

public static class ServiceCollection
{
    public static IServiceCollection AddRepositories(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(o =>
        {
            o.UseSqlServer(configuration.GetConnectionString("TpApi"));
        });

        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<IGameRepository, GameRepository>();

        return services;
    }
}