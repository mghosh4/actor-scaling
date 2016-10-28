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
    public class StatefulGrainReader : StatefulGrain
    {
        public override async Task<string> GetValue(string key, Context cntxt)
        {
            /*if (cntxt.id == 1)
            {
                Console.WriteLine("Sleeping..........{0}", cntxt.id);
                await Task.Delay(60000);
                Console.WriteLine("Done Sleeping..........{0}", cntxt.id);
            }

            Console.WriteLine("{0}: Querying for key {1} {2}", cntxt.id, key, State.Prefs.Count);*/
            return State.Prefs[key];
        }

        public override async Task<IDictionary<string, string>> GetAllEntries(Context cntxt)
        {
            return State.Prefs;
        }
    }

    public class StronglyConsistentReader : StatefulGrainReader, MWMROrleansInterfaces.IStronglyConsistentReader
    {

    }

    public class EventuallyConsistentReader : StatefulGrainReader, MWMROrleansInterfaces.IEventuallyConsistentReader
    {

    }

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
}
