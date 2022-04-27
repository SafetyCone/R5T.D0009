using System;
using System.Threading.Tasks;

using R5T.D0003;
using R5T.D0008;
using R5T.T0064;


namespace R5T.D0009.D0003
{
    [ServiceImplementationMarker]
    public class ProcessStartTimeDirectoryNameProvider : IProcessStartTimeDirectoryNameProvider, IServiceImplementation
    {
        private IProcessStartTimeProvider ProcessStartTimeProvider { get; }
        private ITimestampUtcDirectoryNameProvider TimestampUtcDirectoryNameProvider { get; }


        public ProcessStartTimeDirectoryNameProvider(
            IProcessStartTimeProvider processStartTimeProvider,
            ITimestampUtcDirectoryNameProvider timestampUtcDirectoryNameProvider)
        {
            this.ProcessStartTimeProvider = processStartTimeProvider;
            this.TimestampUtcDirectoryNameProvider = timestampUtcDirectoryNameProvider;
        }

        public async Task<string> GetProcessStartTimeDirectoryName()
        {
            var processStartTime = await this.ProcessStartTimeProvider.GetProcessStartTimeAsync();

            var processStartTimeDirectoryName = await this.TimestampUtcDirectoryNameProvider.GetTimestampUtcDirectoryNameAsync(processStartTime);
            return processStartTimeDirectoryName;
        }
    }
}
