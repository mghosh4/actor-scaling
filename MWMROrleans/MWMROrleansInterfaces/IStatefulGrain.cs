using System.Threading.Tasks;
using System.Collections.Generic;
using Orleans;

namespace MWMROrleansInterfaces
{
    /// <summary>
    /// Grain interface IGrain1
    /// </summary>
    public interface IStatefulGrain : IGrainWithIntegerKey
    {
        Task<string> SayHello();
    }

    public interface IStatefulGrainReader : IStatefulGrain
    {
        Task<string> GetValue(string key);

        Task<IDictionary<string, string>> GetAllEntries();
    }

    public interface IStatefulGrainWriter : IStatefulGrain
    {
        Task SetValue(KeyValuePair<string, string> entry);

        Task ClearValues();
    }
}
