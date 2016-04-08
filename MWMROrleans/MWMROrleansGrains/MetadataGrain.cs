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
            State.readerGrains = new List<string>();
            State.writerGrains = new List<string>();
            await base.OnActivateAsync();
        }

        public async Task<IStatefulGrain> GetGrain(string primaryKey, bool readwrite, string grainClassNamePrefix = null)
        {            
            IStatefulGrain grain = null;
            if (readwrite == true)
            {
                grain = GrainFactory.GetGrain<IStatefulGrainWriter>(primaryKey, grainClassNamePrefix);
            }
            else
            {
                grain = GrainFactory.GetGrain<IStatefulGrainReader>(primaryKey, grainClassNamePrefix);
            }

            if (readwrite == false && State.readerGrains.Contains(primaryKey) == false)
            {
                foreach (string key in State.writerGrains)
                {
                    // Console.WriteLine("\n\nRegister Reader Grain {0}\n\n", key);
                    var writergrain = GrainFactory.GetGrain<IStatefulGrainWriter>(key);
                    await writergrain.RegisterReaderGrain(primaryKey);
                    // Console.WriteLine("\n\nDone\n\n");
                }

                State.readerGrains.Add(primaryKey);
            }
            else if (readwrite == true && State.writerGrains.Contains(primaryKey) == false)
            {
                foreach (string key in State.readerGrains)
                {
                    // Console.WriteLine("\n\nRegister Reader Grain{0}\n\n", key);
                    await grain.RegisterReaderGrain(key);
                }

                foreach (string key in State.writerGrains)
                {
                    // Console.WriteLine("\n\nRegister Writer Grain{0}\n\n", key);
                    await grain.RegisterWriterGrain(key);

                    var writergrain = GrainFactory.GetGrain<IStatefulGrainWriter>(key);
                    await writergrain.RegisterReaderGrain(primaryKey);
                }

                State.writerGrains.Add(primaryKey);
            }

            return grain;
        }
    }
    
    public class MetadataGrainState : GrainState
    {
        public IList<string> readerGrains { get; set; }

        public IList<string> writerGrains { get; set; }
    }

}
