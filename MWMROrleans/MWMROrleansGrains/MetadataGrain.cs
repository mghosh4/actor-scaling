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
        public const string STRONG_WRITER = "strongwriter";
        public const string STRONG_READER = "strongreader";
        public const string RMW_READER = "readmywritereader";
        public const string EVENTUAL_READER = "eventualreader";
        public const string BOUNDED_STALENESS_READER = "boundedstalenessreader";

        public override async Task OnActivateAsync()
        {
            if (State.writers == null)
                State.writers = new Dictionary<string, ConsistencyLevel>();

            if (State.readers == null)
                State.readers = new Dictionary<string, ConsistencyLevel>();

            State.numInstances = State.writers.Count + State.readers.Count;

            await base.OnActivateAsync();
        }

        public async Task<IStatefulGrain> GetGrain(bool readwrite, ConsistencyLevel level)
        {
            IStatefulGrain grain = null;
            string primaryKey = null;
            if (readwrite == true)
            {
                switch(level)
                {
                    case ConsistencyLevel.STRONG:
                        //TODO: Implement policy to see if new grain is needed.
                        //For now, we create a new grain each time
                        primaryKey = MetadataGrain.STRONG_WRITER + State.numInstances;
                        State.numInstances++;
                        grain = GrainFactory.GetGrain<IStronglyConsistentWriter>(primaryKey);
                        foreach (KeyValuePair<string, ConsistencyLevel> entry in State.readers)
                        {
                            await grain.RegisterReaderGrain(entry.Key, entry.Value);
                        }

                        foreach (KeyValuePair<string, ConsistencyLevel> entry in State.writers)
                        {
                            await grain.RegisterWriterGrain(entry.Key, entry.Value);

                            IStatefulGrain writergrain = null;
                            switch(entry.Value)
                            {
                                case ConsistencyLevel.STRONG:
                                    writergrain = GrainFactory.GetGrain<IStronglyConsistentWriter>(entry.Key);
                                    break;
                                case ConsistencyLevel.EVENTUAL:
                                    throw new NotImplementedException();
                            }

                            await writergrain.RegisterWriterGrain(primaryKey, ConsistencyLevel.STRONG);
                        }

                        State.writers.Add(primaryKey, ConsistencyLevel.STRONG);
                        break;
                    case ConsistencyLevel.EVENTUAL:
                        throw new NotImplementedException();
                }
                
            }
            else
            {
                switch (level)
                {
                    case ConsistencyLevel.STRONG:
                        //TODO: Implement policy to see if new grain is needed.
                        //For now, we create a new grain each time
                        primaryKey = MetadataGrain.STRONG_READER + State.numInstances;
                        State.numInstances++;
                        grain = GrainFactory.GetGrain<IStronglyConsistentReader>(primaryKey);
                        break;
                    case ConsistencyLevel.READ_MY_WRITE:
                        primaryKey = MetadataGrain.RMW_READER + State.numInstances;
                        State.numInstances++;
                        grain = GrainFactory.GetGrain<IReadMyWriteReader>(primaryKey);
                        break;
                    case ConsistencyLevel.BOUNDED:
                        primaryKey = MetadataGrain.BOUNDED_STALENESS_READER + State.numInstances;
                        State.numInstances++;
                        grain = GrainFactory.GetGrain<IBoundedStalenessReader>(primaryKey);
                        break;
                    case ConsistencyLevel.EVENTUAL:
                        primaryKey = MetadataGrain.EVENTUAL_READER + State.numInstances;
                        State.numInstances++;
                        grain = GrainFactory.GetGrain<IEventuallyConsistentReader>(primaryKey);
                        break;
                }

                KeyValuePair<string, ConsistencyLevel> strongwriter = State.writers.First(writer => writer.Value == ConsistencyLevel.STRONG);
                await grain.RegisterWriterGrain(strongwriter.Key, strongwriter.Value);

                foreach (KeyValuePair<string, ConsistencyLevel> entry in State.writers)
                {
                    IStatefulGrain writergrain = null;
                    switch (entry.Value)
                    {
                        case ConsistencyLevel.STRONG:
                            writergrain = GrainFactory.GetGrain<IStronglyConsistentWriter>(entry.Key);
                            break;
                        case ConsistencyLevel.EVENTUAL:
                            throw new NotImplementedException();
                    }

                    await writergrain.RegisterReaderGrain(primaryKey, level);
                }

                State.readers.Add(primaryKey, ConsistencyLevel.STRONG);
            }

            return grain;
        }

        public async Task<IStatefulGrain> GetGrain(string primaryKey, bool readwrite, ConsistencyLevel level)
        {
            IStatefulGrain grain = null;
            if (readwrite == true)
            {
                switch (level)
                {
                    case ConsistencyLevel.STRONG:
                        grain = GrainFactory.GetGrain<IStronglyConsistentWriter>(primaryKey);
                        break;
                    case ConsistencyLevel.EVENTUAL:
                        throw new NotImplementedException();
                }

            }
            else
            {
                switch (level)
                {
                    case ConsistencyLevel.STRONG:
                        grain = GrainFactory.GetGrain<IStronglyConsistentReader>(primaryKey);
                        break;
                    case ConsistencyLevel.READ_MY_WRITE:
                        grain = GrainFactory.GetGrain<IReadMyWriteReader>(primaryKey);
                        break;
                    case ConsistencyLevel.BOUNDED:
                        grain = GrainFactory.GetGrain<IBoundedStalenessReader>(primaryKey);
                        break;
                    case ConsistencyLevel.EVENTUAL:
                        grain = GrainFactory.GetGrain<IEventuallyConsistentReader>(primaryKey);
                        break;
                }
            }

            return grain;
        }
    }
    
    public class MetadataGrainState : GrainState
    {
        public IDictionary<string, ConsistencyLevel> writers { get; set; }

        public IDictionary<string, ConsistencyLevel> readers { get; set; }

        public long numInstances;
    }

}
