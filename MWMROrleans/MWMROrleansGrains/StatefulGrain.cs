using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Orleans;
using Orleans.Concurrency;
using Orleans.Providers;

using MWMROrleansInterfaces;

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
            State.readerGrains = new List<string>();
            State.writerGrains = new List<string>();
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

        public Task RegisterReaderGrain(string key)
        {
            throw new NotImplementedException();
        }

        public Task DeregisterReaderGrain(string key)
        {
            throw new NotImplementedException();
        }

        public Task RegisterWriterGrain(string key)
        {
            throw new NotImplementedException();
        }

        public Task DeregisterWriterGrain(string key)
        {
            throw new NotImplementedException();
        }
    }

    public class StatefulGrainReader : StatefulGrain
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

    [StatelessWorker]
    public class StronglyConsistentReader: StatefulGrainReader, MWMROrleansInterfaces.IStronglyConsistentReader
    {

    }

    [StatelessWorker]
    public class EventuallyConsistentReader : StatefulGrainReader, MWMROrleansInterfaces.IEventuallyConsistentReader
    {

    }
    
    public class StatefulGrainWriter : StatefulGrainReader
    {
        public async Task SetValue(KeyValuePair<string, string> entry)
        {
            Console.WriteLine("\n\n{0}\n\n", entry.ToString());
            State.Prefs.Add(entry);

            await updateOtherGrainState();
        }

        public async Task ClearValues()
        {
            State.Prefs.Clear();

            await updateOtherGrainState();
        }

        private async Task updateOtherGrainState()
        {
            var metadatagrainfactory = GrainFactory.GetGrain<IMetadataGrain>(0);
            foreach (string key in State.readerGrains)
            {
                // Console.WriteLine("\n\n{0}\n\n", key);
                IStatefulGrain stategrain = await metadatagrainfactory.GetGrain(false, ConsistencyLevel.STRONG);
                await stategrain.SetState(State);
            }

            foreach (string key in State.writerGrains)
            {
                // Console.WriteLine("\n\n{0}\n\n", key);
                IStatefulGrain stategrain = await metadatagrainfactory.GetGrain(true, ConsistencyLevel.STRONG);
                await stategrain.SetState(State);
            }
        }

        public Task RegisterReaderGrain(string key)
        {
            // Console.WriteLine("\n\nRegisterReaderGrain {0}\n\n", key);

            if (State.readerGrains.Contains(key) == true)
            {
                throw new Exception();
            }

            State.readerGrains.Add(key);

            // Console.WriteLine("\n\nDone\n\n");

            return TaskDone.Done;
        }

        public Task DeregisterReaderGrain(string key)
        {
            if (State.readerGrains.Contains(key) == false)
            {
                throw new KeyNotFoundException();
            }

            State.readerGrains.Remove(key);

            return TaskDone.Done;
        }

        public Task RegisterWriterGrain(string key)
        {
            if (State.writerGrains.Contains(key) == true)
            {
                throw new Exception();
            }

            State.writerGrains.Add(key);

            return TaskDone.Done;
        }

        public Task DeregisterWriterGrain(string key)
        {
            if (State.writerGrains.Contains(key) == false)
            {
                throw new KeyNotFoundException();
            }

            State.writerGrains.Remove(key);

            return TaskDone.Done;
        }
    }

    public class StronglyConsistentWriter : StatefulGrainWriter, MWMROrleansInterfaces.IStronglyConsistentWriter
    {
    }

    public class EventuallyConsistentWriter : StatefulGrainWriter, MWMROrleansInterfaces.IEventuallyConsistentWriter
    {
    }

    [Serializable]
    public class StatefulGrainState : GrainState
    {
        public IDictionary<string, string> Prefs { get; set; }

        public IList<string> readerGrains { get; set; }

        public IList<string> writerGrains { get; set; }
    }
}
