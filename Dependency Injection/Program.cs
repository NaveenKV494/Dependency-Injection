using System;
using Microsoft.Extensions.DependencyInjection;
using static Dependency_Injection.Implementation;
using static Dependency_Injection.Interfaces;

namespace Dependency_Injection
{


    class Program
    {
        static void Main(string[] args)
        {
            // Create a service collection
            var services = new ServiceCollection();

            // Register dependencies
            services.AddSingleton<IGun, LaserGun>();
            services.AddSingleton<ISword, EnergySword>();
            services.AddSingleton<ITransformer, Transformer>();

            // Build the service provider
            var serviceProvider = services.BuildServiceProvider();

            // Resolve the Transformer and call the Attack method
            var transformer = serviceProvider.GetRequiredService<ITransformer>();
            transformer.Attack();

            Console.ReadLine();
        }
    }

}
