using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace AtEase.Extensions.DependencyInjection.Test
{
    public class ServiceCollectionExtensionsTests
    {
        [Fact]
        public void ReplaceSingleton_should_replace_object_with_new_object()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<ISingleton>(new NormalSingleton());

            ServiceProvider serviceProvider = services.BuildServiceProvider();

            ISingleton singleton = serviceProvider.GetService<ISingleton>();

            singleton.GetName().Should().Be(nameof(NormalSingleton));


            services.ReplaceSingleton<ISingleton, SingletonWithPublicCtor>();

            serviceProvider = services.BuildServiceProvider();

            singleton = serviceProvider.GetService<ISingleton>();

            singleton.GetName().Should().Be(nameof(SingletonWithPublicCtor));
        }


        [Fact]
        public void ReplaceSingleton_when_new_object_has_factory_should_replace_object_with_new_object()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<ISingleton>(new NormalSingleton());

            ServiceProvider serviceProvider = services.BuildServiceProvider();

            ISingleton singleton = serviceProvider.GetService<ISingleton>();

            singleton.GetName().Should().Be(nameof(NormalSingleton));


            services.ReplaceSingleton<ISingleton>(SingletonWithStaticFactory.CreateNew());

            serviceProvider = services.BuildServiceProvider();

            singleton = serviceProvider.GetService<ISingleton>();

            singleton.GetName().Should().Be(nameof(SingletonWithStaticFactory));
        }
    }
}