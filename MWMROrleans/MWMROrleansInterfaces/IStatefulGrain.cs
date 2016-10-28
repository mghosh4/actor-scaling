using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Orleans;

namespace MWMROrleansInterfaces
{
    /// <summary>
    /// Grain interface IStatefulGrain
    /// </summary>
    public interface IStatefulGrain : IGrainWithStringKey
    {
        Task SetState(GrainState state);

        Task<GrainState> GetState();

        Task<string> GetValue(string key, Context cntxt);

        Task<IDictionary<string, string>> GetAllEntries(Context cntxt);

        Task<Context> SetValue(KeyValuePair<string, string> entry);

        Task<Context> ClearValues();

        Task RegisterReaderGrain(string key, ConsistencyLevel level);

        Task DeregisterReaderGrain(string key);

        Task RegisterWriterGrain(string key, ConsistencyLevel level);

        Task DeregisterWriterGrain(string key);
    }

    public struct Context
    {
        public DateTime timestamp;
        public long id;
    }

}
