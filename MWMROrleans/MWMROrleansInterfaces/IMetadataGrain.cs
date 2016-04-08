using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Orleans;

namespace MWMROrleansInterfaces
{
    public interface IMetadataGrain : IGrainWithIntegerKey
    {
        Task<IStatefulGrain> GetGrain(string primaryKey, bool readwrite, string grainClassNamePrefix = null);
    }
}
