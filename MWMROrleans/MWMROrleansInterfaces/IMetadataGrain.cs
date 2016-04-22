using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Orleans;

namespace MWMROrleansInterfaces
{
    public enum ConsistencyLevel
    {
        STRONG,
        EVENTUAL,
        READ_MY_WRITE,
        MONOTONIC,
        BOUNDED,
        CAUSAL
    }

    public interface IMetadataGrain : IGrainWithIntegerKey
    {
        Task<IStatefulGrain> GetGrain(bool readwrite, ConsistencyLevel level);
    }
}
