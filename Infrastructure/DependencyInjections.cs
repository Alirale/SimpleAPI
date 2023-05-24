using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            return services;
        }
    }
}