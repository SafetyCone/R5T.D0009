using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0009.D0003
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ProcessStartTimeDirectoryNameProvider"/> implementation of <see cref="IProcessStartTimeDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddD0003ProcessStartTimeDirectoryNameProvider(this IServiceCollection services)
        {
            services.AddSingleton<IProcessStartTimeDirectoryNameProvider, ProcessStartTimeDirectoryNameProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ProcessStartTimeDirectoryNameProvider"/> implementation of <see cref="IProcessStartTimeDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IProcessStartTimeDirectoryNameProvider> AddD0003ProcessStartTimeDirectoryNameProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IProcessStartTimeDirectoryNameProvider>.New(() => services.AddD0003ProcessStartTimeDirectoryNameProvider());
            return serviceAction;
        }
    }
}
