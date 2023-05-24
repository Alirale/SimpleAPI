using Application.Interfaces;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddSingleton<IAuthorizationService, AuthorizationService>();
            return services;
        }
    }
}