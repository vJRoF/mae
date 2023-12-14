using Mae.DataAccess.Abstractions;
using Mae.DataAccess.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Mae.DataAccess;

public static class RegisterExtension
{
    public static void AddRepositories(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IDayValueRepository, DayValueRepository>();
    }
}