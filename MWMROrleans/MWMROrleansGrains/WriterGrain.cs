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
    public class StatefulGrainWriter : StatefulGrainReader
    {
        public virtual async Task<Context> SetValue(KeyValuePair<string, string> entry)
        {
            Console.WriteLine("\n\n{0}\n\n", entry.ToString());
            State.Prefs.Add(entry);

            await updateOtherGrainState();

            Context cntxt;
            cntxt.timestamp = DateTime.Now;
            cntxt.id = 0;
            State.currentContext.timestamp = cntxt.timestamp;

            return cntxt;
        }

        public virtual async Task<Context> ClearValues()
        {
            State.Prefs.Clear();

            await updateOtherGrainState();

            Context cntxt;
            cntxt.timestamp = DateTime.Now;
            cntxt.id = 0;
            State.currentContext.timestamp = cntxt.timestamp;

            return cntxt;
        }

        public virtual async Task updateOtherGrainState()
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
}
