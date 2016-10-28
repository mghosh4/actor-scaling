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

    [Serializable]
    public class StatefulGrainState : GrainState
    {
        public IDictionary<string, string> Prefs { get; set; }

        public Context currentContext;

        public IDictionary<string, ConsistencyLevel> readers { get; set; }

        public IDictionary<string, ConsistencyLevel> writers { get; set; }
    }
}
