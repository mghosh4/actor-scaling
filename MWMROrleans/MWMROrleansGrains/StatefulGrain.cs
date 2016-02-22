using System.Threading.Tasks;
using Orleans;

namespace MWMROrleansGrains
{
    /// <summary>
    /// Grain implementation class Grain1.
    /// </summary>
    public class StatefulGrain : Grain, MWMROrleansInterfaces.IStatefulGrain
    {
        public Task<string> SayHello()
        {
            return Task.FromResult("Hello World!");
        }
    }
}
