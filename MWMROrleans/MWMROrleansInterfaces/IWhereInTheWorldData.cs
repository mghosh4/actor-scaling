using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWMROrleansInterfaces
{
    public interface IWhereInTheWorldData : IStronglyConsistentWriter
    {
        Task StartLease(DateTime time);
    }

    public interface IWITWDMetadataGrain : IMetadataGrain
    {
        Task<IWhereInTheWorldData> GetNearestFullReplica();
        Task<List<string>> GetAllFullReplicas();
    }
}
