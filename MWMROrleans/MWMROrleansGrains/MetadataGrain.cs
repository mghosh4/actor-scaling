using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Orleans;
using Orleans.Concurrency;
using Orleans.Providers;

using MWMROrleansInterfaces;

namespace MWMROrleansGrains
{
    [StorageProvider(ProviderName = "MemoryStore")]
    public class MetadataGrain : Grain<MetadataGrainState>, MWMROrleansInterfaces.IMetadataGrain
    {
        public override async Task OnActivateAsync()
        {
            State.stronglyConsistentReaders = new List<string>();
            State.stronglyConsistentReaders = new List<string>();
            State.eventuallyConsistentReaders = new List<string>();
            await base.OnActivateAsync();
        }

        public async Task<IStatefulGrain> GetGrain(bool readwrite, ConsistencyLevel level)
        {
            IStatefulGrain grain = null;
            string primaryKey;
            if (readwrite == true)
            {
                switch(level)
                {
                    case ConsistencyLevel.STRONG:
                        primaryKey = "strongwriter";
                        grain = GrainFactory.GetGrain<IStronglyConsistentWriter>(primaryKey);
                        if (State.stronglyConsistentWriters.Contains(primaryKey) == false)
                        {
                            foreach (string key in State.stronglyConsistentReaders)
                            {
                                // Console.WriteLine("\n\nRegister Reader Grain{0}\n\n", key);
                                await grain.RegisterReaderGrain(key);
                            }

                            foreach (string key in State.stronglyConsistentWriters)
                            {
                                // Console.WriteLine("\n\nRegister Writer Grain{0}\n\n", key);
                                await grain.RegisterWriterGrain(key);

                                var writergrain = GrainFactory.GetGrain<IStronglyConsistentWriter>(key);
                                await writergrain.RegisterReaderGrain(primaryKey);
                            }

                            State.stronglyConsistentWriters.Add(primaryKey);
                        }

                        break;
                    case ConsistencyLevel.EVENTUAL:
                        throw new Exception();
                }
                
            }
            else
            {
                switch (level)
                {
                    case ConsistencyLevel.STRONG:
                        primaryKey = "strongreader";
                        grain = GrainFactory.GetGrain<IStronglyConsistentReader>(primaryKey);
                        if (State.stronglyConsistentReaders.Contains(primaryKey) == false)
                        {
                            foreach (string key in State.stronglyConsistentWriters)
                            {
                                // Console.WriteLine("\n\nRegister Reader Grain {0}\n\n", key);
                                var writergrain = GrainFactory.GetGrain<IStronglyConsistentWriter>(key);
                                await writergrain.RegisterReaderGrain(primaryKey);
                                // Console.WriteLine("\n\nDone\n\n");
                            }

                            State.stronglyConsistentReaders.Add(primaryKey);
                        }
                        break;
                    case ConsistencyLevel.EVENTUAL:
                        primaryKey = "eventualreader";
                        grain = GrainFactory.GetGrain<IEventuallyConsistentReader>(primaryKey);
                        break;
                }
            }

            return grain;
        }
    }
    
    public class MetadataGrainState : GrainState
    {
        public IList<string> stronglyConsistentReaders { get; set; }

        public IList<string> stronglyConsistentWriters { get; set; }

        public IList<string> eventuallyConsistentReaders { get; set; }
    }

}
