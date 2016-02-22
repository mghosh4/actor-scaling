using System.Threading.Tasks;
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
}
