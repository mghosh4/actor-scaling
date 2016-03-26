using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Orleans;
using Orleans.Concurrency;
using Orleans.Providers;

namespace MWMROrleansGrains
{
    /// <summary>
    /// Grain implementation class Grain1.
    /// </summary>
    [StorageProvider(ProviderName = "MemoryStore")]
    public class StatefulGrain : Grain<StatefulGrainState>, MWMROrleansInterfaces.IStatefulGrain
    {
        public override Task OnActivateAsync()
        {
            if (State.Prefs == null)
            {
                State.Prefs = new Dictionary<string, string>();
            }
            return base.OnActivateAsync();
        }

        public Task<string> SayHello()
        {
            return Task.FromResult("Hello World!");
        }

        public Task<string> GetValue(string key)
        {
            throw new NotImplementedException();
        }

        public Task<IDictionary<string, string>> GetAllEntries()
        {
            throw new NotImplementedException();
        }

        public Task SetValue(KeyValuePair<string, string> entry)
        {
            throw new NotImplementedException();
        }

        public Task ClearValues()
        {
            throw new NotImplementedException();
        }
    }

    [StatelessWorker]
    public class StatefulGrainReader : StatefulGrain, MWMROrleansInterfaces.IStatefulGrainReader
    {
        public Task<string> GetValue(string key)
        {
            return Task.FromResult(State.Prefs[key]);
        }

        public Task<IDictionary<string, string>> GetAllEntries()
        {
            return Task.FromResult(State.Prefs);
        }
    }

    public class StatefulGrainWriter : StatefulGrainReader, MWMROrleansInterfaces.IStatefulGrainWriter
    {
        public Task SetValue(KeyValuePair<string, string> entry)
        {
            Console.WriteLine("\n\n{0}\n\n", entry.ToString());
            State.Prefs.Add(entry);
            return TaskDone.Done;
        }

        public Task ClearValues()
        {
            State.Prefs.Clear();
            return TaskDone.Done;
        }
    }

    public class StatefulGrainState : GrainState
    {
        public IDictionary<string, string> Prefs { get; set; }
    }
}
