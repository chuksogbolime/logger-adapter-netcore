using System;
using Microsoft.Extensions.DependencyInjection;
namespace NetCoreLoggerAdapter
{
    public static class DependencyConfiguration
    {
        public static void ConfigureLogAdapter(this IServiceCollection services)
        {
            services.AddSingleton(typeof(ILoggerServiceAdapter<>), typeof(LoggerServiceAdapter<>));
        }
    }
}
