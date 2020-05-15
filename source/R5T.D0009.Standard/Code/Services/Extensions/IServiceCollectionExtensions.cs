using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.D0009.D0003;


namespace R5T.D0009.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IProcessStartTimeDirectoryNameProvider"/> service.
        /// </summary>
        public static IServiceCollection AddProcessStartTimeDirectoryNameProvider(this IServiceCollection services)
        {
            services.AddD0003ProcessStartTimeDirectoryNameProvider();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IProcessStartTimeDirectoryNameProvider"/> service.
        /// </summary>
        public static ServiceAction<IProcessStartTimeDirectoryNameProvider> AddProcessStartTimeDirectoryNameProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IProcessStartTimeDirectoryNameProvider>.New(() => services.AddProcessStartTimeDirectoryNameProvider());
            return serviceAction;
        }
    }
}
