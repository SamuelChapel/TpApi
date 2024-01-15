using TpApi.Api.Mappers;

namespace TpApi.Api.Extensions;

public static class ServiceCollection
{
    public static IServiceCollection AddApi(this IServiceCollection services)
    {
        services.AddScoped<UserMapper>();

        return services;
    }
}
