using System;
using System.Threading.Tasks;


namespace R5T.D0009
{
    public interface IProcessStartTimeDirectoryNameProvider
    {
        Task<string> GetProcessStartTimeDirectoryName();
        Task<string> GetProcessStartTimeUtcDirectoryName();
    }
}
