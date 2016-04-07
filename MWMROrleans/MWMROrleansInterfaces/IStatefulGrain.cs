using System.Threading.Tasks;
using System.Collections.Generic;
using Orleans;

namespace MWMROrleansInterfaces
{
    /// <summary>
    /// Grain interface IGrain1
    /// </summary>
    public interface IStatefulGrain : IGrainWithStringKey
    {
        Task SetState(GrainState state);

        Task<string> GetValue(string key);

        Task<IDictionary<string, string>> GetAllEntries();

        Task SetValue(KeyValuePair<string, string> entry);

        Task ClearValues();
    }

    public interface IStatefulGrainReader : IStatefulGrain
    {
    }

    public interface IStatefulGrainWriter : IStatefulGrainReader
    {
    }
}
