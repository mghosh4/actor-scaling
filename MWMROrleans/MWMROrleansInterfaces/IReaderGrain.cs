using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Orleans;

namespace MWMROrleansInterfaces
{
    public interface IStronglyConsistentReader : IStatefulGrain
    {
    }

    public interface IEventuallyConsistentReader : IStatefulGrain
    {
    }

    public interface IReadMyWriteReader : IStatefulGrain
    {
    }

    public interface IBoundedStalenessReader : IStatefulGrain
    {
    }
}
