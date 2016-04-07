using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Orleans;
using Orleans.Concurrency;
using Orleans.Providers;

using MWMROrleansInterfaces;
using MWMROrleans;

namespace MWMROrleansGrains
{
    /// <summary>
    /// Grain implementation class Grain1.
    /// </summary>
    [StorageProvider(ProviderName = "MemoryStore")]
    public class StatefulGrain : Grain<StatefulGrainState>, MWMROrleansInterfaces.IStatefulGrain
    {
        public override async Task OnActivateAsync()
        {
            State.Prefs = new Dictionary<string, string>();
            await base.OnActivateAsync();
        }

        public Task SetState(GrainState state)
        {
            State.Prefs = (state as StatefulGrainState).Prefs;
            return TaskDone.Done;
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

            List<IStatefulGrain> othergrains = MetadataGrainFactory.GetAllGrains();
            Console.WriteLine("\n\n{0}\n\n", othergrains.Count);
            foreach (IStatefulGrain grain in othergrains)
            {
                if (grain != this)
                {
                    Console.WriteLine("\n\n{0}\n\n", entry.ToString());
                    grain.SetState(State).Wait();
                }
            }

            return TaskDone.Done;
        }

        public Task ClearValues()
        {
            State.Prefs.Clear();
            List<IStatefulGrain> othergrains = MetadataGrainFactory.GetAllGrains();
            foreach (IStatefulGrain grain in othergrains)
            {
                if (grain != this)
                    grain.SetState(State).Wait();
            }

            return TaskDone.Done;
        }
    }

    public class StatefulGrainState : GrainState
    {
        public IDictionary<string, string> Prefs { get; set; }
    }
}
