using Microsoft.Extensions.DependencyInjection;
using TpApi.Business.Contracts;
using TpApi.Business.Services;

namespace TpApi.Business.Extensions;

public static class ServiceCollection
{
    public static IServiceCollection AddBusiness(this IServiceCollection services)
    {
        services.AddTransient<IUserService, UserService>();
        services.AddTransient<IGameService, GameService>();

        return services;
    }
}
