using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Timers;
using System.Linq;
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
            if (State.Prefs == null)
                State.Prefs = new Dictionary<string, string>();

            if (State.readers == null)
                State.readers = new Dictionary<string, ConsistencyLevel>();

            if (State.writers == null)
                State.writers = new Dictionary<string, ConsistencyLevel>();

            await base.OnActivateAsync();
        }

        public virtual Task SetState(GrainState state)
        {
            State.Prefs = (state as StatefulGrainState).Prefs;
            State.currentContext = (state as StatefulGrainState).currentContext;
            // Metadata grain should be doing this. This is not state for the grain to maintain
            //State.readers = (state as StatefulGrainState).readers;
            //State.writers = (state as StatefulGrainState).writers;
            return TaskDone.Done;
        }

        public virtual Task<GrainState> GetState()
        {
            return Task.FromResult<GrainState>(State);
        }

        public virtual Task<string> GetValue(string key, Context cntxt)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IDictionary<string, string>> GetAllEntries(Context cntxt)
        {
            throw new NotImplementedException();
        }

        public virtual Task<Context> SetValue(KeyValuePair<string, string> entry)
        {
            throw new NotImplementedException();
        }

        public virtual Task<Context> ClearValues()
        {
            throw new NotImplementedException();
        }

        public virtual Task RegisterReaderGrain(string key, ConsistencyLevel level)
        {
            if (State.readers.ContainsKey(key) == true)
            {
                throw new Exception();
            }

            State.readers.Add(key, level);

            return TaskDone.Done;
        }

        public virtual Task DeregisterReaderGrain(string key)
        {
            if (State.readers.ContainsKey(key) == false)
            {
                throw new KeyNotFoundException();
            }

            State.readers.Remove(key);

            return TaskDone.Done;
        }

        public virtual Task RegisterWriterGrain(string key, ConsistencyLevel level)
        {
            if (State.writers.ContainsKey(key) == true)
            {
                throw new Exception();
            }

            State.writers.Add(key, level);

            return TaskDone.Done;
        }

        public virtual Task DeregisterWriterGrain(string key)
        {
            if (State.writers.ContainsKey(key) == false)
            {
                throw new KeyNotFoundException();
            }

            State.writers.Remove(key);

            return TaskDone.Done;
        }
    }

    public class StatefulGrainReader : StatefulGrain
    {
        public override async Task<string> GetValue(string key, Context cntxt)
        {
            return State.Prefs[key];
        }

        public override async Task<IDictionary<string, string>> GetAllEntries(Context cntxt)
        {
            return State.Prefs;
        }
    }

    [StatelessWorker]
    public class StronglyConsistentReader : StatefulGrainReader, MWMROrleansInterfaces.IStronglyConsistentReader
    {

    }

    [StatelessWorker]
    public class EventuallyConsistentReader : StatefulGrainReader, MWMROrleansInterfaces.IEventuallyConsistentReader
    {

    }

    [StatelessWorker]
    public class ReadMyWriteReader : StatefulGrainReader, MWMROrleansInterfaces.IReadMyWriteReader
    {
        private async Task updateState(Context cntxt)
        {
            if (State.currentContext.timestamp < cntxt.timestamp)
            {
                var metadatagrainfactory = GrainFactory.GetGrain<IMetadataGrain>(0);
                //TODO: this may break if the reader is created before any writer
                IStatefulGrain writergrain = await metadatagrainfactory.GetGrain(State.writers.First().Key, true, State.writers.First().Value);
                GrainState state = await writergrain.GetState();
                await SetState(state);
            }
        }

        public override async Task<string> GetValue(string key, Context cntxt)
        {
            await updateState(cntxt);
            return State.Prefs[key];
        }

        public override async Task<IDictionary<string, string>> GetAllEntries(Context cntxt)
        {
            await updateState(cntxt);
            return State.Prefs;
        }
    }

    [StatelessWorker]
    public class BoundedStalenessReader : StatefulGrainReader, MWMROrleansInterfaces.IReadMyWriteReader
    {
        public override async Task OnActivateAsync()
        {
            Timer periodicRun = new Timer();
            periodicRun.Elapsed += new ElapsedEventHandler(periodicDataUpdate);
            periodicRun.Interval = 5000;
            periodicRun.Enabled = true;

            await base.OnActivateAsync();
        }

        public async void periodicDataUpdate(object source, ElapsedEventArgs e)
        {
            var metadatagrainfactory = GrainFactory.GetGrain<IMetadataGrain>(0);
            //TODO: this may break if the reader is created before any writer
            IStatefulGrain writergrain = await metadatagrainfactory.GetGrain(State.writers.First().Key, true, State.writers.First().Value);
            GrainState state = await writergrain.GetState();
            await SetState(state);
        }
    }
    
    public class StatefulGrainWriter : StatefulGrainReader
    {
        public async Task<Context> SetValue(KeyValuePair<string, string> entry)
        {
            Console.WriteLine("\n\n{0}\n\n", entry.ToString());
            State.Prefs.Add(entry);

            await updateOtherGrainState();

            Context cntxt;
            cntxt.timestamp = DateTime.Now;
            State.currentContext.timestamp = cntxt.timestamp;

            return cntxt;
        }

        public async Task<Context> ClearValues()
        {
            State.Prefs.Clear();

            await updateOtherGrainState();

            Context cntxt;
            cntxt.timestamp = DateTime.Now;
            State.currentContext.timestamp = cntxt.timestamp;

            return cntxt;
        }

        private async Task updateOtherGrainState()
        {
            var metadatagrainfactory = GrainFactory.GetGrain<IMetadataGrain>(0);
            foreach (KeyValuePair<string, ConsistencyLevel> entry in State.readers)
            {
                switch(entry.Value)
                {
                    case ConsistencyLevel.STRONG:
                        IStatefulGrain stategrain = await metadatagrainfactory.GetGrain(entry.Key, false, entry.Value);
                        await stategrain.SetState(State);
                        break;
                }
            }

            foreach (KeyValuePair<string, ConsistencyLevel> entry in State.writers)
            {
                switch (entry.Value)
                {
                    case ConsistencyLevel.STRONG:
                        IStatefulGrain stategrain = await metadatagrainfactory.GetGrain(entry.Key, true, entry.Value);
                        await stategrain.SetState(State);
                        break;
                    case ConsistencyLevel.EVENTUAL:
                        throw new NotImplementedException();
                }
            }
        }
    }

    public class StronglyConsistentWriter : StatefulGrainWriter, MWMROrleansInterfaces.IStronglyConsistentWriter
    {
    }

    [Serializable]
    public class StatefulGrainState : GrainState
    {
        public IDictionary<string, string> Prefs { get; set; }

        public Context currentContext;

        public IDictionary<string, ConsistencyLevel> readers { get; set; }

        public IDictionary<string, ConsistencyLevel> writers { get; set; }
    }
}
