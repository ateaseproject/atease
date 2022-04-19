using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace AtEase.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ReplaceSingleton<TService, TImplementation>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            services.Replace(ServiceDescriptor.Singleton<TService, TImplementation>());
            return services;
        }

        public static IServiceCollection ReplaceSingleton<TService>(
        this IServiceCollection services,
        TService instance) where TService : class

        {
            services.Replace(ServiceDescriptor.Singleton(instance));
            return services;
        }
    }
}